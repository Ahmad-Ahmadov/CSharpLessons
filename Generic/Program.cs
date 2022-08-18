using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    interface ICrudRepository<T> where T : class,new()//constraint
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int id);
        List<T> GetAll();
    }

    class BaseRepository<TEntity> : ICrudRepository<TEntity> where TEntity : class,new()
    {
        
        public void Add(TEntity entity)
        {

            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
    class Car{}

    class CarDal : BaseRepository<Car>
    {

    }


    class Program
    {
        public static List<T> GetList<T>(ArrayList m)
        {
            List<T> list = new List<T>();
            foreach (var item in m)
            {
                if (item.GetType() == typeof(T))
                    list.Add((T)item);
            }
            return list;
        }

        static void Main(string[] args)
        {
            
            ArrayList list = new ArrayList();
            list.Add("HELLO");
            list.Add(25);
            list.Add("Ahmad");
            list.Add(35.6);
            list.Add("Resad");
            list.Add(36);
            list.Add("Medine");
            list.Add(true);
            list.Add(false);
            var m = GetList<double>(list);

            foreach (var l in m)
            {
                Console.WriteLine(l);
            }


            Console.Read();

        }
    }
}
