﻿using Abp.Auditing;
using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Abp.Zero.Ldap;
using Abp.Zero.Ldap.Configuration;
using Serendip.IK.Authorization.Roles;
using Serendip.IK.Authorization.Users;
using Serendip.IK.Configuration;
using Serendip.IK.Ldap;
using Serendip.IK.Localization;
using Serendip.IK.MultiTenancy;
using Serendip.IK.Timing;
using Serendip.IK.Utility;

namespace Serendip.IK
{
    [DependsOn(typeof(AbpZeroCoreModule), typeof(AbpZeroLdapModule))]
    public class IKCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.ReplaceService(typeof(IAuditingStore), () =>
            {
                IocManager.Register<IAuditingStore, CustomAuditStore>();
            });

            Configuration.Auditing.IsEnabled = true;
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;
            IocManager.Register<ISuratLdapSettings, SuratLdapSettings>();
            Configuration.Modules.ZeroLdap().Enable(typeof(SuratLdapAuthenticationSource));
            Configuration.Auditing.SaveReturnValues = true;
            Configuration.EntityHistory.IsEnabled = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            IKLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = IKConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            Configuration.Settings.Providers.Add<LdapSettingProvider>(); 
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IKCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
