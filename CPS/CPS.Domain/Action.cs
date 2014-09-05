using System;
using System.Collections.Generic;

namespace CPS.Domain
{
    public class Action : Entity
    {
        public Action()
        {
            Documents = new List<Document>();
        }

        public virtual Claim Claim { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime RecordDate { get; set; }
        public virtual IList<Document> Documents { get; set; }

        public virtual void AddDocument(Document attachment)
        {
            attachment.Action = this;
            this.Documents.Add(attachment);
        }
    }
}
