﻿using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Serendip.IK.Authorization.Users;
using Serendip.IK.Editions;

namespace Serendip.IK.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        #region Constructor
        public TenantManager(
            IRepository<Tenant> tenantRepository,
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository,
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore)
            : base(
                tenantRepository,
                tenantFeatureRepository,
                editionManager,
                featureValueStore)
        {
        } 
        #endregion
    }
}
