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
namespace AutoDealer.DB.its_honda
{

    [Persistent(@"users")]
    public partial class UsersModel : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>("id", ref fid, value); }
        }
        string fusername;
        [Size(255)]
        public string username
        {
            get { return fusername; }
            set { SetPropertyValue<string>("username", ref fusername, value); }
        }
        string fpassword;
        [Size(255)]
        public string password
        {
            get { return fpassword; }
            set { SetPropertyValue<string>("password", ref fpassword, value); }
        }
        string fcreated_by;
        [Size(255)]
        public string created_by
        {
            get { return fcreated_by; }
            set { SetPropertyValue<string>("created_by", ref fcreated_by, value); }
        }
        DateTime flast_login;
        public DateTime last_login
        {
            get { return flast_login; }
            set { SetPropertyValue<DateTime>("last_login", ref flast_login, value); }
        }
        DateTime fcreatedAt;
        public DateTime createdAt
        {
            get { return fcreatedAt; }
            set { SetPropertyValue<DateTime>("createdAt", ref fcreatedAt, value); }
        }
        DateTime fupdatedAt;
        public DateTime updatedAt
        {
            get { return fupdatedAt; }
            set { SetPropertyValue<DateTime>("updatedAt", ref fupdatedAt, value); }
        }
        DateTime fdeletedAt;
        public DateTime deletedAt
        {
            get { return fdeletedAt; }
            set { SetPropertyValue<DateTime>("deletedAt", ref fdeletedAt, value); }
        }
        int fversion;
        public int version
        {
            get { return fversion; }
            set { SetPropertyValue<int>("version", ref fversion, value); }
        }
        KaryawansModel fkaryawanId;
        [Association(@"UsersModelReferencesKaryawansModel")]
        public KaryawansModel karyawanId
        {
            get { return fkaryawanId; }
            set { SetPropertyValue<KaryawansModel>("karyawanId", ref fkaryawanId, value); }
        }
        UserRolesModel fuserRoleId;
        [Association(@"UsersModelReferencesUserRolesModel")]
        public UserRolesModel userRoleId
        {
            get { return fuserRoleId; }
            set { SetPropertyValue<UserRolesModel>("userRoleId", ref fuserRoleId, value); }
        }
        string femail;
        [Size(255)]
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>("email", ref femail, value); }
        }
    }

}
