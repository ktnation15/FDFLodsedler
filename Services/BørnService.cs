﻿using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.EntityFrameworkCore;

namespace FDFLodsedler.Services
{
    public class BørnService : IBørn
    {
        private ApplicationDBContext Context;

        public BørnService(ApplicationDBContext context)
        {
            Context = context;
        }

        public void AddBørn(Børn børn)
        {
            Context.Børns.Add(børn);
            Context.SaveChanges();

        }

        public Børn GetAllBørn(int id)
        {
            Børn børn = Context.Børns.FirstOrDefault(b => b.Børn_Id == id);
            return børn;
        }

        public IEnumerable<Børn> GetBørn()
        {
            return Context.Børns;
        }

        public void RemoveBørn(Børn børn)
        {
            Context.Remove(børn);
            Context.SaveChanges();
        }

        public void Update(Børn Updatebørn)
        {
            Børn ExistingChild = Context.Børns.FirstOrDefault(e => e.Børn_Id == Updatebørn.Børn_Id);



            if (ExistingChild != null)
            {

                ExistingChild.Navn = Updatebørn.Navn;
                ExistingChild.GruppeId = Updatebørn.GruppeId;


            }


            Context.SaveChanges();


        }

    }
}