
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CancelPhysicalInventory : EntityAction<PhysicalInventoryReview>
    {
 public CancelPhysicalInventory(PhysicalInventoryReview entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public PhysicalInventoryReview Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}