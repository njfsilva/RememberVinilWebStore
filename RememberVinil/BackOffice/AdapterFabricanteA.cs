﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOffice.FabricanteAService;

namespace BackOffice
{
    public class AdapterFabricanteA : IAdapterFabricantes
    {

        private FabricanteAService.FabricanteAServiceClient AFabricanteA { get; set; }

        public AdapterFabricanteA(FabricanteAService.FabricanteAServiceClient a)
        {
            AFabricanteA = a;

        }
        
        
        public double getPrice(List<Track> list)
        {
            return AFabricanteA.getQuote(newQuoteRequest(list));

        }

        public ObjectQuoteRequest newQuoteRequest(List<Track> list)
        {
            ObjectQuoteRequest request = new ObjectQuoteRequest();
            request.WSCallback = "xxxxxxx";
            
            Music[] arrayOfMusic = new Music[list.Count];
            int x = 0;
            foreach (Track t in list)
	        {
		            Music m = new Music();
                    m.nome=t.TrackName;
                    m.price=t.Price;
                    arrayOfMusic[x]=m;
                    x++;
	        }
            request.ListaMusicas = arrayOfMusic;
            return request;
        }
    }
}