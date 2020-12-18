using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.ProductSkus
{
    public class Inventory : ValueObject
    {
        /// <summary>
        /// 可售库存(真实库存)
        /// </summary>
        public int Sellable { get; private set; }
        /// <summary>
        /// 可用库存
        /// </summary>
        public int Available { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aSellable"></param>
        /// <param name="aAvailable"></param>
        public Inventory(int aSellable, int aAvailable)
        {
            Sellable = aSellable;
            Available = aAvailable;
        }
        /// <summary>
        /// 预占库存
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Inventory Preempted(int quantity)
        {
            if (quantity > Available)
                throw new ArgumentException("可用库存不足");
            return new Inventory(Sellable, Available - quantity);
        }
        /// <summary>
        /// 释放预占库存
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Inventory Release(int quantity)
        {
            return new Inventory(Sellable, Available + quantity);
        }

        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Inventory Outbound(int quantity)
        {
            if (quantity > Sellable)
                throw new ArgumentException("库存不足");
            return new Inventory(Sellable - quantity, Available);
        }
        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Inventory Restocking(int quantity)
        {
            return new Inventory(Sellable + quantity, Available + quantity);
        }
    }
}
