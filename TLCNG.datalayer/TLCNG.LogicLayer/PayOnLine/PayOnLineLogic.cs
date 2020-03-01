using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLCNG.datalayer;
using TLCNG.entities;
using TLCNG.LogicLayer.Repository;

namespace TLCNG.LogicLayer.PayOnLine
{
    public class PayOnLineLogic
    {
        private CrudOperations<CAJAS_Pago> PaymentBoxesManage;

        public PayOnLineLogic()
        {
            PaymentBoxesManage = new CrudOperations<CAJAS_Pago>();
        }

        public PayOnLineLogic(BDCatastroTulancingoEntities context)
        {
            PaymentBoxesManage = new CrudOperations<CAJAS_Pago>(context);
        }

        public BDCatastroTulancingoEntities Context { get { return PaymentBoxesManage.ContextModel; } }

        public async Task<Result<List<CAJAS_Pago>>> GetCajasPagos()
        {
            Result<List<CAJAS_Pago>> result = new Result<List<CAJAS_Pago>>();

            try
            {
                PaymentBoxesManage.ContextModel.Configuration.LazyLoadingEnabled = false;

                result.Data = (from cajas in PaymentBoxesManage.ContextModel.CAJAS_Pago
                               select cajas).ToList();

                if (result.Data == null && result.Data.Count==0)
                {
                    result.HasError = true;

                    result.Message = "no existen datos";
                }

            }
            catch (Exception exp)
            {

                result.HasError = true;

                result.Message = "No existe la clave";

            }
            return result;
        }
    }
}
