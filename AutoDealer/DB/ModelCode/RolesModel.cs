﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AutoDealer.DB.DMS
{

    public partial class RolesModel
    {
        public RolesModel(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
