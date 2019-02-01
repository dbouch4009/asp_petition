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
    // For adding new signatures
    public class SignatureController : ApiController
    {
        private ApplicationDbContext _context;

        public SignatureController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Mvc.HttpPost]
        public void CreateSignature(NewSignatureViewModel newSignatureViewModel)
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
                entry.CommunityId = newSignatureViewModel.CommunityId;
                entry.EntryTime = DateTime.Now;
                entry.GivenReasonId = new Guid();
                entry.EntryId = new Guid();
                entry.PersonId = new Guid();
            }

            var person = new Person();
            {
                person.FirstName = newSignatureViewModel.FirstName;
                person.LastName = newSignatureViewModel.LastName;
                person.Id = entry.PersonId;
                person.ShowPublicly = newSignatureViewModel.ShowPublicly;
            }

            var reason = new GivenReason();
            {
                reason.Id = entry.GivenReasonId;
                reason.GivenReasonDetail = newSignatureViewModel.GivenReasonDetail;
            }


            _context.Entries.Add(entry);
            _context.SaveChanges();

        }
    }
}
