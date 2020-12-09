using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Pictures
{
    public class Picture : AggregateRoot<PictureId>
    {
        public string RemoteUrl { get; private set; }
        public string RelativePath { get; private set; }
        public Picture(PictureId aId, string aRemoteUrl, string aRelativePath) : base(aId)
        {
            RemoteUrl = aRemoteUrl;
            RelativePath = aRelativePath;
        }
    }
}
