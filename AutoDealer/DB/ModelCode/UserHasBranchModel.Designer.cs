﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AutoDealer.DB.DMS
{

    [Persistent(@"user_has_branch")]
    public partial class UserHasBranchModel : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>("id", ref fid, value); }
        }
        UserModel fusername;
        [Size(255)]
        [Association(@"UserHasBranchModelReferencesUserModel")]
        public UserModel username
        {
            get { return fusername; }
            set { SetPropertyValue<UserModel>("username", ref fusername, value); }
        }
        BranchModel fbranch_name;
        [Size(255)]
        [Association(@"UserHasBranchModelReferencesBranchModel")]
        public BranchModel branch_name
        {
            get { return fbranch_name; }
            set { SetPropertyValue<BranchModel>("branch_name", ref fbranch_name, value); }
        }
        BranchModel fbranchid;
        [Association(@"UserHasBranchModelReferencesBranchModel1")]
        public BranchModel branchid
        {
            get { return fbranchid; }
            set { SetPropertyValue<BranchModel>("branchid", ref fbranchid, value); }
        }
    }

}
