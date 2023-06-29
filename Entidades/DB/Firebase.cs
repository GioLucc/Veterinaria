using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.DB
{
    public class Firebase
    {
        protected FirestoreDb _db;
        protected CollectionReference _colRef;

        public Firebase(FirestoreDb db, CollectionReference colRef)
        {
            _db = db;
            _colRef = colRef;
        }
    }
}
