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

    [Persistent(@"prospeks")]
    public partial class ProspeksModel : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>("id", ref fid, value); }
        }
        string fnama_prospek;
        [Size(255)]
        public string nama_prospek
        {
            get { return fnama_prospek; }
            set { SetPropertyValue<string>("nama_prospek", ref fnama_prospek, value); }
        }
        string fsumber_data;
        [Size(255)]
        public string sumber_data
        {
            get { return fsumber_data; }
            set { SetPropertyValue<string>("sumber_data", ref fsumber_data, value); }
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
        string fpekerjaan;
        [Size(255)]
        public string pekerjaan
        {
            get { return fpekerjaan; }
            set { SetPropertyValue<string>("pekerjaan", ref fpekerjaan, value); }
        }
        string fdetail_pekerjaan;
        [Size(255)]
        public string detail_pekerjaan
        {
            get { return fdetail_pekerjaan; }
            set { SetPropertyValue<string>("detail_pekerjaan", ref fdetail_pekerjaan, value); }
        }
        string fperusahaan;
        [Size(255)]
        public string perusahaan
        {
            get { return fperusahaan; }
            set { SetPropertyValue<string>("perusahaan", ref fperusahaan, value); }
        }
        string fjabatan;
        [Size(255)]
        public string jabatan
        {
            get { return fjabatan; }
            set { SetPropertyValue<string>("jabatan", ref fjabatan, value); }
        }
        string falamat_perusahaan;
        [Size(255)]
        public string alamat_perusahaan
        {
            get { return falamat_perusahaan; }
            set { SetPropertyValue<string>("alamat_perusahaan", ref falamat_perusahaan, value); }
        }
        string fpembayaran;
        [Size(255)]
        public string pembayaran
        {
            get { return fpembayaran; }
            set { SetPropertyValue<string>("pembayaran", ref fpembayaran, value); }
        }
        decimal fdp;
        public decimal dp
        {
            get { return fdp; }
            set { SetPropertyValue<decimal>("dp", ref fdp, value); }
        }
        decimal ftenor;
        public decimal tenor
        {
            get { return ftenor; }
            set { SetPropertyValue<decimal>("tenor", ref ftenor, value); }
        }
        string ftestdrive;
        [Size(255)]
        public string testdrive
        {
            get { return ftestdrive; }
            set { SetPropertyValue<string>("testdrive", ref ftestdrive, value); }
        }
        string fjumlah;
        [Size(255)]
        public string jumlah
        {
            get { return fjumlah; }
            set { SetPropertyValue<string>("jumlah", ref fjumlah, value); }
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
        SalesModel fsaleId;
        [Association(@"ProspeksModelReferencesSalesModel")]
        public SalesModel saleId
        {
            get { return fsaleId; }
            set { SetPropertyValue<SalesModel>("saleId", ref fsaleId, value); }
        }
        SalesheadsModel fsalesheadId;
        [Association(@"ProspeksModelReferencesSalesheadsModel")]
        public SalesheadsModel salesheadId
        {
            get { return fsalesheadId; }
            set { SetPropertyValue<SalesheadsModel>("salesheadId", ref fsalesheadId, value); }
        }
        BranchmanagersModel fbranchManagerId;
        [Association(@"ProspeksModelReferencesBranchmanagersModel")]
        public BranchmanagersModel branchManagerId
        {
            get { return fbranchManagerId; }
            set { SetPropertyValue<BranchmanagersModel>("branchManagerId", ref fbranchManagerId, value); }
        }
        LeasingsModel fleasingId;
        [Association(@"ProspeksModelReferencesLeasingsModel")]
        public LeasingsModel leasingId
        {
            get { return fleasingId; }
            set { SetPropertyValue<LeasingsModel>("leasingId", ref fleasingId, value); }
        }
        ZipcodesModel fzipcodeZipCode;
        [Association(@"ProspeksModelReferencesZipcodesModel")]
        public ZipcodesModel zipcodeZipCode
        {
            get { return fzipcodeZipCode; }
            set { SetPropertyValue<ZipcodesModel>("zipcodeZipCode", ref fzipcodeZipCode, value); }
        }
        ModelKendaraansModel fmodelKendaraanId;
        [Association(@"ProspeksModelReferencesModelKendaraansModel")]
        public ModelKendaraansModel modelKendaraanId
        {
            get { return fmodelKendaraanId; }
            set { SetPropertyValue<ModelKendaraansModel>("modelKendaraanId", ref fmodelKendaraanId, value); }
        }
        WarnaKendaraansModel fwarnaKendaraanId;
        [Association(@"ProspeksModelReferencesWarnaKendaraansModel")]
        public WarnaKendaraansModel warnaKendaraanId
        {
            get { return fwarnaKendaraanId; }
            set { SetPropertyValue<WarnaKendaraansModel>("warnaKendaraanId", ref fwarnaKendaraanId, value); }
        }
        TransmisiKendaraansModel ftransmisiKendaraanId;
        [Association(@"ProspeksModelReferencesTransmisiKendaraansModel")]
        public TransmisiKendaraansModel transmisiKendaraanId
        {
            get { return ftransmisiKendaraanId; }
            set { SetPropertyValue<TransmisiKendaraansModel>("transmisiKendaraanId", ref ftransmisiKendaraanId, value); }
        }
        string fnama_kecamatan;
        [Size(255)]
        public string nama_kecamatan
        {
            get { return fnama_kecamatan; }
            set { SetPropertyValue<string>("nama_kecamatan", ref fnama_kecamatan, value); }
        }
        string fmerk_kendaraan;
        [Size(255)]
        public string merk_kendaraan
        {
            get { return fmerk_kendaraan; }
            set { SetPropertyValue<string>("merk_kendaraan", ref fmerk_kendaraan, value); }
        }
        string ftipe_kendaraan;
        [Size(255)]
        public string tipe_kendaraan
        {
            get { return ftipe_kendaraan; }
            set { SetPropertyValue<string>("tipe_kendaraan", ref ftipe_kendaraan, value); }
        }
        [Association(@"ProspekDetailsModelReferencesProspeksModel")]
        public XPCollection<ProspekDetailsModel> ProspekDetailsModelCollection { get { return GetCollection<ProspekDetailsModel>("ProspekDetailsModelCollection"); } }
    }

}