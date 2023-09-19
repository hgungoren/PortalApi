using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Serendip.IK.SKJobs.Dto;
using Serendip.IK.SKJobs.Dto.RequestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Serendip.IK.SKJobs
{
    public class SKJobsAppService : AsyncCrudAppService<SKJobs, SKJobDto, long, PagedJobResultRequestDto, CreateJobsDto, SKJobDto>, ISKJobsAppService
    {
        public SKJobsAppService(IRepository<SKJobs, long> repository) : base(repository)
        {
        }

        #region GetAllPositionForTitle

        public async Task<IList<SKJobsPromoteListDto>> GetAllPositionForTitle(SKJobsPromoteRequestDto sKJobsPromoteRequestDto)
        {
            List<SKJobsPromoteListDto> datas = new List<SKJobsPromoteListDto>();
            var title = await Repository.GetAllListAsync(x => x.ObjId == sKJobsPromoteRequestDto.ObjId);

            var priorty = title[0].Durum;
            var Departmant = title[0].DepartmanObjId;
            var Birim = title[0].BirimObjId;

            //var result = await Repository.GetAllListAsync(x => x.BirimObjId == sKJobsPromoteRequestDto.BirimObjId);
            var result = await Repository.GetAllListAsync(x => x.BirimObjId == Birim&&x.DepartmanObjId==Departmant);
            result = result.Where(x => x.Durum > priorty).Distinct().ToList();
           
            if (priorty != null&&result.Count()>0)

            {
                result = result.Where(x => x.Durum > priorty).Distinct().ToList();

                foreach (var item in result.Select(a => new{a.Durum,a.Adi}).Distinct())
                {
                    datas.Add(new SKJobsPromoteListDto
                    {
                        Durum = item.Durum,
                        Adi = item.Adi
                    });
                }
            }
            else
            {
                datas.Add(new SKJobsPromoteListDto
                {
                    Durum = 0,
                    Adi = "Terfi edilebilecek title bulunamadı."
                });

            }
            return datas;
        } 
        #endregion

        #region GetAllPositionForUnit
        [HttpGet]
        public async Task<List<SKJobsNameDto>> GetAllPositionForUnit(long unitObjId)
        {
            List<SKJobsNameDto> datas = new List<SKJobsNameDto>();
            var names = await Repository.GetAllListAsync(x => x.BirimObjId == unitObjId);
            foreach (var item in names)
            {
                if (String.IsNullOrEmpty(item.Adi) != true)
                {
                    datas.Add(new SKJobsNameDto
                    {
                        Adi = item.Adi,
                    });
                }
            }
            return datas;
        }
        #endregion
    }
}
