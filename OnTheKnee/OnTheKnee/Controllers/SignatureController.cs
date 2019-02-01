using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using OnTheKnee.Models;
using OnTheKnee.ViewModels;

namespace OnTheKnee.Controllers
{
    public class SignatureController : ApiController
    {
        private ApplicationDbContext _context;

        public SignatureController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Mvc.HttpPost]
        public void CreateSignature()
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewSignatureViewModel
                {

                };

                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var entry = new Entry();
            {
                //TODO Map me
            }

            _context.Entries.Add(entry);
            _context.SaveChanges();

        }
    }
}
