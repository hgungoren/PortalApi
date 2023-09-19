﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Runtime.Session;
using Microsoft.Extensions.Configuration;
using Refit;
using Serendip.IK.KPersonels;
using Serendip.IK.KPersonels.Dto;
using Serendip.IK.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serendip.IK.KBolges
{

    public class KPersonelAppService
        : AsyncCrudAppService<KPersonel, KPersonelDto, long, PagedKPersonelResultRequestDto, CreateKPersonelDto, KPersonelDto>, IKPersonelAppService
    {
        #region Constructor
        private const string SERENDIP_SERVICE_BASE_URL = ApiConsts.K_PERSONEL_API_URL;
        private readonly IAbpSession _abpSession;
        private readonly IUserAppService _userAppService;
        private readonly IConfiguration _configuration;

        public KPersonelAppService(
            IRepository<KPersonel, long> repository,
            IAbpSession abpSession, IUserAppService userAppService,
            IConfiguration configuration
            ) : base(repository)
        {
            this._abpSession = abpSession;
            this._userAppService = userAppService;
            this._configuration = configuration;
        }
        #endregion

        #region GetAll
        //[
        //    AbpAuthorize(PermissionNames.items_user_view, PermissionNames.items_kBranchDetail_employee_table)
        //]
        public override async Task<PagedResultDto<KPersonelDto>> GetAllAsync(PagedKPersonelResultRequestDto input)
        {
            string id = input.Id;
            if (string.IsNullOrWhiteSpace(id))
            {
                var userId = _abpSession.GetUserId();
                var user = await _userAppService.GetAsync(new EntityDto<long> { Id = userId });
                id = user.CompanyObjId.ToString();
            }

            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);

            var data = service
                .GetAllBySube(id).Result
                .Where(x => x.Aktif == true)
                .OrderBy(x => x.Ad);

            var result = data.AsQueryable()
                .WhereIf(input.Keyword != "",
                x => x.Ad.ToLower().Contains(input.Keyword) ||
                x.Soyad.ToLower().Contains(input.Keyword) ||
                x.SicilNo.Contains(input.Keyword) ||
                x.Gorevi.ToLower().Contains(input.Keyword) ||
                x.ObjId.ToLower().Contains(input.Keyword));

            var dto = new PagedResultDto<KPersonelDto>
            {
                Items = ObjectMapper.Map<List<KPersonelDto>>(result),
                TotalCount = input.Keyword != "" ? result.Count() : data.Count()
            };

            return dto;
        }
        #endregion

        #region GetEmployeesCount
        // TODO : Bu alan düzenlenecek
        public async Task<int> GetEmployeesCount()
        {

            var userId = _abpSession.GetUserId();
            var user = await _userAppService.GetAsync(new EntityDto<long> { Id = userId });
            var roles = user.RoleNames;

            if (roles.Contains("GENEL MÜDÜRLÜK") || roles.Contains("ADMIN"))
            {
                return await GetTotalEmployeeCount();
            }
            else
            {
                return await GetTotalEmployeeCountById(user.CompanyObjId.Value);
            }
        }
        #endregion

        #region GetTotalEmployeeCountById
        public async Task<int> GetTotalEmployeeCountById(long id)
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            return service.TotalCount(id).Result;
        }
        #endregion

        #region GetTotalEmployeeCount
        public async Task<int> GetTotalEmployeeCount()
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            return service.TotalCount().Result;
        }
        #endregion

        #region GetKPersonelByBranchId
        public Task<IEnumerable<KPersonelResponseDto>> GetKPersonelByBranchId(long id, string[] title)
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            return service.GetKPersonelByBranchId(id, title);
        }
        #endregion

        #region GetKPersonelByEmail
        /// <summary>
        /// Personeli Mail Adresine Göre ObjId, IsYeri_ObjId, SicilNo değerini teslim ederi
        /// </summary>
        /// <param name="email">Kullanıcın email adresini giriniz örn. isim.soyisim@suratkargo.com.tr</param>
        /// <returns>
        /// KPersonelInfoDto
        ///  {
        ///     "isyeri_ObjId": 0,
        ///     "sicilNo": null,
        ///     "objId": 0
        ///  } 
        /// </returns>
        public Task<KPersonelInfoDto> GetKPersonelByEmail(string email)
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            return service.GetKPersonelByEmail(email);
        }
        #endregion

        #region GetById
        public Task<KPersonelDto> GetById(long id)
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            return service.GetKPersonelById(id);
        }
        #endregion

        #region GetByObjId
        public async Task<KPersonelGetDto> GetByObjId(long id)
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            var data = await service.GetAll();
            var result = data.Where(x => x.ObjId == id.ToString());
            var dto = new KPersonelGetDto { };
            foreach (var item in result)
            {
                dto.AskerlikDurumu = item.AskerlikDurumu;
                dto.OgrenimDurumu = item.OgrenimDurumu;
                dto.Gorevi = item.Gorevi;
                dto.SicilNo = item.SicilNo;
                dto.IseBaslamaTarihi = item.GrubaGirisTarihi;
                dto.SonTerfiTarihi = DateTime.Now;

            }
            return dto;
        }
        #endregion
        #region GetKPersonelByEmails
        public async Task<List<KPersonelDto>> GetKPersonelByEmails(string[] email)
        {
            var service = RestService.For<IKPersonelApi>(SERENDIP_SERVICE_BASE_URL);
            var data = await service.GetKPersonelByEmails(email);

            return data;
        }
        #endregion
    }
}









































//public Task<object> GetAllAreaManagers() { throw new System.NotImplementedException(); }

//public Task<object> GetAllBranchesAsync([Query] int tip, [Query] int tip_tur) => throw new System.NotImplementedException();