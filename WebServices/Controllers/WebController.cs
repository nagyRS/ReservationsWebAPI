using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    // after creating the API controller, call localhost/api/web for XML or JSON  <api/web(contoller)/id>

    // the URL will produce a list of all the model objects

    public class WebController : ApiController
    {
        private ReservationRepository repo = ReservationRepository.Current;

        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }

        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }


        [HttpPost]                                                     //added attribute
        public Reservation CreateReservation(Reservation item)      //changed the method name form PostReservation
        {
            return repo.Add(item);
        }

        [HttpPut]
        public bool UpdateReservation(Reservation item)             // changed the name from PutReservation
        {
            return repo.Update(item);
        }

        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}
