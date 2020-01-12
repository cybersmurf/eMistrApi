﻿using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class UserSettings
    {
        public int Id { get; set; }
        public string FormatHodin { get; set; }
        public string ZakazkaTimeout { get; set; }
        public string AutoSelectGroup { get; set; }
        public string ShowDatacolToppan { get; set; }
        public string OrderStavyrazeni { get; set; }
        public string BtnImport { get; set; }
        public string BtnCalc { get; set; }
        public string BarFormat { get; set; }
        public string ProskrtavatDochazku { get; set; }
        public string ProskrtavaciZnak { get; set; }
        public string SberdatOdprac { get; set; }
        public string DesOddelovac { get; set; }
        public string PrintDefault { get; set; }
        public string PrintCopyes { get; set; }
        public string PrintAll { get; set; }
        public string PrintSavepozice { get; set; }
        public string PrintOffsetX { get; set; }
        public string PrintOffsetY { get; set; }
        public string Rezerva { get; set; }
        public string CteckaRizeniToku { get; set; }
        public string CteckaPort { get; set; }
        public string CteckaStopbit { get; set; }
        public string CteckaDatabit { get; set; }
        public string CteckaLaser { get; set; }
        public string CteckaAutocheck { get; set; }
        public string PopupDatumy { get; set; }
        public string Barvy { get; set; }
        public string Styly { get; set; }
        public string ColorPasiveActive { get; set; }
        public int UserId { get; set; }
        public string SelectGroupOper { get; set; }
        public string LastSelectedOrderwork { get; set; }
        public string LastSelectedOrderworkGroup { get; set; }
        public string AutoNeukoncenePrichody { get; set; }
        public string VyberTisku { get; set; }
        public string PrintDefaultBrothers { get; set; }
        public string PrintBrothersUse { get; set; }
        public string PrintBarcodeUse { get; set; }
        public string AutoSelectGroupSklad { get; set; }
        public string SelectGroupSklad { get; set; }
        public string ZmenaNaStav { get; set; }
        public int Popisgrafprehled { get; set; }
        public string LastSelectedKusu { get; set; }
        public string BtnStavyzak { get; set; }
        public string LastSelectedPredmatGroup { get; set; }
        public string LastSelectedPredmatId { get; set; }
        public string AutoSelectLastPredpmat { get; set; }
        public string OrderUserfiltr { get; set; }
        public int RychlaMys { get; set; }
        public int ChkMater { get; set; }
        public string PrintPodpis { get; set; }
        public int UseAktDateOrd { get; set; }
        public DateTime StartAktDateOrd { get; set; }
        public DateTime FinAktDateOrd { get; set; }
        public int UseChkOwTime { get; set; }
        public int PrintDoc { get; set; }
        public int UseClipboard { get; set; }
        public int OrdShowBtntoday { get; set; }
        public int OrdChkmaterVzdy { get; set; }
        public int PrnAdvVykYisk { get; set; }
        public int UseDefOrderstav { get; set; }
        public int OrdTemplName { get; set; }
        public string OrdSablonaSett { get; set; }
        public int OwDefPoradi { get; set; }
        public int OrdBoldMaster { get; set; }
        public int OrdColorMaster { get; set; }
        public string CteckaPrijemkaPort { get; set; }
        public int CteckaPrijemkaAutocheck { get; set; }
        public string CteckaVydejkaPort { get; set; }
        public int CteckaVydejkaAutocheck { get; set; }
        public int CteckaSkladMs5145 { get; set; }
        public int OperacePrekrocenyCasPrebarvit { get; set; }
        public int OperacePrekrocenyCasBarva { get; set; }
        public int ZakDetail1 { get; set; }
        public int ZakDetail2 { get; set; }
        public int ZakDetail3 { get; set; }
        public int ZakDetail4 { get; set; }
        public int ZakDetail5 { get; set; }
        public int ZakDetail6 { get; set; }
        public int ZakHeightDet1 { get; set; }
        public int ZakHeightDet2 { get; set; }
        public int ZakHeightDet4 { get; set; }
        public int ZakHeightDet6 { get; set; }
        public int ZakHeightDet3 { get; set; }
        public int ZakHeightDet5 { get; set; }
        public int GrafPrehledZakLeft { get; set; }
        public int GrafPrehledZakBoot1 { get; set; }
        public int GrafPrehledZakBoot2 { get; set; }
        public DateTime CasKlon { get; set; }
        public int AutoAktDateOrd { get; set; }
        public int UseAktDateSklad { get; set; }
        public DateTime StartAktDateSklad { get; set; }
        public DateTime FinAktDateSklad { get; set; }
        public int AutoAktDateSklad { get; set; }
        public int VariantaAutoposun { get; set; }
        public int KontrolaKonecObdobiMin { get; set; }
        public int SkladDetail1 { get; set; }
        public int SkladDetail2 { get; set; }
        public int SkladDetail3 { get; set; }
        public int SkladHeightDet1 { get; set; }
        public int SkladHeightDet2 { get; set; }
        public int SkladHeightDet3 { get; set; }
        public int SkladPravyPanel { get; set; }
        public int SkladPravyPanelWidth { get; set; }
        public int ExcelExportVarianta { get; set; }
        public string ExcelExportCesta { get; set; }
        public int ExcelExportOtevrit { get; set; }
        public int ZakMaterialPrehledWidth { get; set; }
        public int ZakPredMaterialPrehledWidth { get; set; }
        public int SkladPrehledWidth { get; set; }
        public int ZakMaterialPrehledPravyPanel { get; set; }
        public int ZakMaterialPredPrehledPravyPanel { get; set; }
        public int AktivmiZakazkyHromadneBlokace { get; set; }
        public int CorderAutorefresh { get; set; }
        public int CorderAutorefreshInterval { get; set; }
        public int CorderPredpokladanyCasZdroj { get; set; }
        public int DashboardShow { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int UserNosOrder { get; set; }
        public string UserRealName { get; set; }
        public int AutoAktDateOrdBefore { get; set; }
        public int AutoAktDateOrdAfter { get; set; }
        public int OrderAutoQueryRefreshListBack { get; set; }
        public int OrderType { get; set; }
        public int OrderRada { get; set; }
        public int OrderFinishNull { get; set; }
        public int OrderSettings { get; set; }
        public string UserLanguage { get; set; }
        public int OperaceTop5Days { get; set; }
        public int ColorizeGridCell { get; set; }
        public int UseDefOrdertyp { get; set; }
    }
}
