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

    [Persistent(@"permission")]
    public partial class PermissionModel : XPLiteObject
    {
        string fpermission_name;
        [Key]
        [Size(255)]
        public string permission_name
        {
            get { return fpermission_name; }
            set { SetPropertyValue<string>("permission_name", ref fpermission_name, value); }
        }
        long fpermission_type;
        public long permission_type
        {
            get { return fpermission_type; }
            set { SetPropertyValue<long>("permission_type", ref fpermission_type, value); }
        }
        string fpermission_code;
        [Size(255)]
        public string permission_code
        {
            get { return fpermission_code; }
            set { SetPropertyValue<string>("permission_code", ref fpermission_code, value); }
        }
        string fparent_permission;
        [Size(255)]
        public string parent_permission
        {
            get { return fparent_permission; }
            set { SetPropertyValue<string>("parent_permission", ref fparent_permission, value); }
        }
        DateTime fcreated_at;
        public DateTime created_at
        {
            get { return fcreated_at; }
            set { SetPropertyValue<DateTime>("created_at", ref fcreated_at, value); }
        }
        string fcreated_by;
        [Size(255)]
        public string created_by
        {
            get { return fcreated_by; }
            set { SetPropertyValue<string>("created_by", ref fcreated_by, value); }
        }
    }

}
