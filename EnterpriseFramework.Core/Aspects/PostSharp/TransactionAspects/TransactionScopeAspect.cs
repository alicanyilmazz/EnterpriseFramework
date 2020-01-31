using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EnterpriseFramework.Core.Aspects.PostSharp.TransactionAspects
{
    [Serializable]
    public class TransactionScopeAspect : OnMethodBoundaryAspect
    {
        private TransactionScopeOption _option;
        public TransactionScopeAspect()
        {

        }
        public TransactionScopeAspect(TransactionScopeOption option)
        {
            _option = option;
        }

        /// <summary>
        /// Use opening TransactionScope to beginin of the method.
        /// </summary>
        /// <param name="args">Transaction Scope Parameter</param>
        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_option);
        }

        /// <summary>
        /// Use for successful try operation (try = OnSuccess)
        /// </summary>
        /// <param name="args"></param>
        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}
