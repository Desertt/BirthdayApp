﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {

            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Merve", new DavetiyeModel
            {
                Ad = "Hayatının Her Döneminde Mutlu ve Sağlıklı Olmanı Diliyorum",
                Eposta = "merve@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Mustafa", new DavetiyeModel
            {
                Ad = "O güzel gözlerin asla hüzünlenmesin.",
                Eposta = "mustafa@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Miraç", new DavetiyeModel
            {
                Ad = "Bütün Hayallerin Gerçekleşsin,Hayat Güneşi Her Daim Seni Aydınlatsın :)",
                Eposta = "mirac@gmail.com",
                KatilmaDurumu = true
            });
        }
        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }

        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }

        }

    }
}
