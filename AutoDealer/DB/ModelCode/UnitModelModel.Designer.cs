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

    [Persistent(@"unit_model")]
    public partial class UnitModelModel : XPLiteObject
    {
        long fid_model;
        [Key(true)]
        public long id_model
        {
            get { return fid_model; }
            set { SetPropertyValue<long>("id_model", ref fid_model, value); }
        }
        string fkode_model;
        [Size(255)]
        public string kode_model
        {
            get { return fkode_model; }
            set { SetPropertyValue<string>("kode_model", ref fkode_model, value); }
        }
        string fmerk;
        [Size(255)]
        public string merk
        {
            get { return fmerk; }
            set { SetPropertyValue<string>("merk", ref fmerk, value); }
        }
        string ftipe_model;
        [Size(255)]
        public string tipe_model
        {
            get { return ftipe_model; }
            set { SetPropertyValue<string>("tipe_model", ref ftipe_model, value); }
        }
        string fcreated_by;
        [Size(255)]
        public string created_by
        {
            get { return fcreated_by; }
            set { SetPropertyValue<string>("created_by", ref fcreated_by, value); }
        }
        string fupdated_by;
        [Size(255)]
        public string updated_by
        {
            get { return fupdated_by; }
            set { SetPropertyValue<string>("updated_by", ref fupdated_by, value); }
        }
        DateTime fcreated_at;
        public DateTime created_at
        {
            get { return fcreated_at; }
            set { SetPropertyValue<DateTime>("created_at", ref fcreated_at, value); }
        }
        DateTime fupdated_at;
        public DateTime updated_at
        {
            get { return fupdated_at; }
            set { SetPropertyValue<DateTime>("updated_at", ref fupdated_at, value); }
        }
    }

}
