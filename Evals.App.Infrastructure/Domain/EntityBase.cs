using System;

namespace Evals.App.Infrastructure
{
    public class EntityBase
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        #region Utilities

        protected Guid GenerateGuid()
        {
            byte[] guidArray = Guid.NewGuid().ToByteArray();

            var baseDate = new DateTime(1900, 1, 1);
            DateTime now = DateTime.Now;
            var days = new TimeSpan(now.Ticks - baseDate.Ticks);
            TimeSpan msecs = now.TimeOfDay;

            byte[] daysArray = BitConverter.GetBytes(days.Days);
            byte[] msecsArray = BitConverter.GetBytes((long)(msecs.TotalMilliseconds / 3.333333));

            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);

            Array.Copy(daysArray, daysArray.Length - 2, guidArray, guidArray.Length - 6, 2);
            Array.Copy(msecsArray, msecsArray.Length - 4, guidArray, guidArray.Length - 4, 4);

            return new Guid(guidArray);
        }


        #endregion
        
        #region Methods

        public void GenerateIdentity()
        {
            Id = GenerateGuid();
        }

        #endregion

        #region Override

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is EntityBase))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            EntityBase item = (EntityBase)obj;
            return item.Id == Id;
        }
        public static bool operator ==(EntityBase left, EntityBase right)
        {
            if (Equals(left, null))
                return (Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(EntityBase left, EntityBase right)
        {
            return !(left == right);
        }

        #endregion

    }
}

