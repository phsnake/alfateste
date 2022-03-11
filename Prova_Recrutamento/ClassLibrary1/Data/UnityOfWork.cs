namespace UnityOfShop.Data
{

    public interface IUnityOfWork
    {
        void Commit();

        void Rollback();
    }
    public class UnityOfWork : IUnityOfWork
    {  
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            //
        }
    }
}