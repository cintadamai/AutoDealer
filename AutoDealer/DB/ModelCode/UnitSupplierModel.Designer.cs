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

    [Persistent(@"unit_supplier")]
    public partial class UnitSupplierModel : XPLiteObject
    {
        string fkode_supplier;
        [Key]
        [Size(255)]
        public string kode_supplier
        {
            get { return fkode_supplier; }
            set { SetPropertyValue<string>("kode_supplier", ref fkode_supplier, value); }
        }
        string fnama_supplier;
        [Size(255)]
        public string nama_supplier
        {
            get { return fnama_supplier; }
            set { SetPropertyValue<string>("nama_supplier", ref fnama_supplier, value); }
        }
        string falamat;
        [Size(255)]
        public string alamat
        {
            get { return falamat; }
            set { SetPropertyValue<string>("alamat", ref falamat, value); }
        }
        string fno_telepon;
        [Size(255)]
        public string no_telepon
        {
            get { return fno_telepon; }
            set { SetPropertyValue<string>("no_telepon", ref fno_telepon, value); }
        }
        string fnpwp;
        [Size(255)]
        public string npwp
        {
            get { return fnpwp; }
            set { SetPropertyValue<string>("npwp", ref fnpwp, value); }
        }
        string fnama_npwp;
        [Size(255)]
        public string nama_npwp
        {
            get { return fnama_npwp; }
            set { SetPropertyValue<string>("nama_npwp", ref fnama_npwp, value); }
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
