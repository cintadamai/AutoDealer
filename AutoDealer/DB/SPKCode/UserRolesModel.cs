﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AutoDealer.DB.its_honda
{

    public partial class UserRolesModel
    {
        public UserRolesModel(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
