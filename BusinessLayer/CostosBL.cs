﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class CostosBL
    {
        public static List<Costos> GetCostos()
        {
            CostosDALC obj = new CostosDALC();
            return obj.GetCostos();
        }

        public static void InserCostos(List<Costos> ListaCosto)
        {
            CostosDALC obj = new CostosDALC();
            foreach (Costos Cost in ListaCosto)
            {
                obj.InsertCostos(Cost);
            }
        }

        public static void UpdateCostos(List<Costos> ListaCosto)
        {
            CostosDALC obj = new CostosDALC();
            foreach (Costos Cost in ListaCosto)
            {
                obj.UpdateCostos(Cost);
            }
        }
    }


}
