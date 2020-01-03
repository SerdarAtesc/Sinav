using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOgrenci1()
        {
            Sinav.KullaniciGirisi kg = new Sinav.KullaniciGirisi();
            bool kontrol=kg.ogrenciGiris("furkan","123");

            Assert.AreEqual(true, kontrol);
        }
        [TestMethod]
        public void TestOgrenci2()
        {
            Sinav.KullaniciGirisi kg = new Sinav.KullaniciGirisi();
            bool kontrol = kg.ogrenciGiris("ogrenci", "123");

            Assert.AreEqual(true, kontrol);
        }
        [TestMethod]
        public void TestOgrenci3()
        {
            Sinav.KullaniciGirisi kg = new Sinav.KullaniciGirisi();
            bool kontrol = kg.ogrenciGiris("yazilimyapimiodevi", "100");

            Assert.AreEqual(false, kontrol);
        }

        [TestMethod]
        public void TestOgretmen1()
        {
            Sinav.KullaniciGirisi kg = new Sinav.KullaniciGirisi();
            bool kontrol = kg.ogretmenGiris("ogrertmen", "123");

            Assert.AreEqual(true, kontrol);
        }
        [TestMethod]
        public void TestOgretmen2()
        {
            Sinav.KullaniciGirisi kg = new Sinav.KullaniciGirisi();
            bool kontrol = kg.ogretmenGiris("EminBorandag", "123");

            Assert.AreEqual(false, kontrol);
        }





    }
}
