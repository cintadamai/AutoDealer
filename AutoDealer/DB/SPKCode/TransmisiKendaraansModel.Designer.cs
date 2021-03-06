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

    [Persistent(@"transmisi_kendaraans")]
    public partial class TransmisiKendaraansModel : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>("id", ref fid, value); }
        }
        string fnama_transmisi;
        [Size(255)]
        public string nama_transmisi
        {
            get { return fnama_transmisi; }
            set { SetPropertyValue<string>("nama_transmisi", ref fnama_transmisi, value); }
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
        [Association(@"ProspeksModelReferencesTransmisiKendaraansModel")]
        public XPCollection<ProspeksModel> ProspeksModelCollection { get { return GetCollection<ProspeksModel>("ProspeksModelCollection"); } }
    }

}
