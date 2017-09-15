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

    [Persistent(@"prospek_details")]
    public partial class ProspekDetailsModel : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>("id", ref fid, value); }
        }
        string fstatus_informasi;
        [Size(255)]
        public string status_informasi
        {
            get { return fstatus_informasi; }
            set { SetPropertyValue<string>("status_informasi", ref fstatus_informasi, value); }
        }
        DateTime fupdate_date;
        public DateTime update_date
        {
            get { return fupdate_date; }
            set { SetPropertyValue<DateTime>("update_date", ref fupdate_date, value); }
        }
        DateTime ftanggal_followup;
        public DateTime tanggal_followup
        {
            get { return ftanggal_followup; }
            set { SetPropertyValue<DateTime>("tanggal_followup", ref ftanggal_followup, value); }
        }
        string fjenis_pertemuan;
        [Size(255)]
        public string jenis_pertemuan
        {
            get { return fjenis_pertemuan; }
            set { SetPropertyValue<string>("jenis_pertemuan", ref fjenis_pertemuan, value); }
        }
        string fketerangan;
        [Size(255)]
        public string keterangan
        {
            get { return fketerangan; }
            set { SetPropertyValue<string>("keterangan", ref fketerangan, value); }
        }
        DateTime fnext_followup;
        public DateTime next_followup
        {
            get { return fnext_followup; }
            set { SetPropertyValue<DateTime>("next_followup", ref fnext_followup, value); }
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
        ProspeksModel fprospekId;
        [Association(@"ProspekDetailsModelReferencesProspeksModel")]
        public ProspeksModel prospekId
        {
            get { return fprospekId; }
            set { SetPropertyValue<ProspeksModel>("prospekId", ref fprospekId, value); }
        }
    }

}