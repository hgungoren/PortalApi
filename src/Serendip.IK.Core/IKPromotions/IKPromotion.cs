﻿using Serendip.IK.Common;
using SuratKargo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serendip.IK.IKPromotions
{
    public class IKPromotion : BaseEntity
    {
        public string RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string LevelOfEducation { get; set; }
        public string PromotionRequestTitle { get; set; }
        public string MilitaryStatus { get; set; }
        public string Department { get; set; }
        public long? DepartmentObjId { get; set; }
        public string Unit { get; set; }
        public long? UnitObjId { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime? LastPromotionDate { get; set; }
        public IKPromotionType Statu { get; set; }
        public IKPromotionStatu HierarchyStatu { get; set; }
    }
}
