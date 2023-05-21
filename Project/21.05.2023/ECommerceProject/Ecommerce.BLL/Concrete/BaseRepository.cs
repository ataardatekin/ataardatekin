using Ecommerce.BLL.Abstract;
using ECommerce.DAL.Context;
using ECommerce.Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly EcommerceContext _context;
        private readonly DbSet<T> _entities;
        public BaseRepository(EcommerceContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        

        public string Create(T entity)
        {
            try
            {
                //_context.Set<T>().Add(entity);
                _entities.Add(entity);
                _context.SaveChanges();
                return "Veri kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(T entity)
        {
            try
            {
                //var deleted = GetById(entity.Id);
                //_entities.Remove(deleted);
                //_context.SaveChanges();
                //return "Veri silindi!";
                var deleted = GetById(entity.Id);
                deleted.Status = ECommerce.Entity.Enum.Status.Deleted;
                //Updated
                Update(deleted);
                return "Veri silindi!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(x => x.Status == 
            ECommerce.Entity.Enum.Status.Created || x.Status == 
            ECommerce.Entity.Enum.Status.Updated);
        }

        public T GetById(int id)
        {
            var entity = _entities.Find(id);
            return entity;
            
        }

        //todo: güncelleme test işlemi
        public string Update(T entity)
        {
            string result = "";
            try
            {
                switch(entity.Status)
                {
                    case ECommerce.Entity.Enum.Status.Updated:
                    case ECommerce.Entity.Enum.Status.Created:
                        entity.Status = ECommerce.Entity.Enum.Status.Updated;
                        _context.Entry(entity).State = EntityState.Modified;
                        _context.SaveChanges();
                        result = "Veri güncellendi!";
                        break;


                    case ECommerce.Entity.Enum.Status.Deleted:
                        entity.Status = ECommerce.Entity.Enum.Status.Deleted;
                        _context.SaveChanges();
                        break;
                }
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            return result;
        }
    }
}
