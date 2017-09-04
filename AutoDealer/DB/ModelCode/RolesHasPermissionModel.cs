using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AutoDealer.DB.DMS
{

    public partial class RolesHasPermissionModel
    {
        public RolesHasPermissionModel(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
