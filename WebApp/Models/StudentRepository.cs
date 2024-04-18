namespace WebApp.Models
{
    public class StudentRepository
    {
        StoreContext _context;
        public StudentRepository(StoreContext context)
        {
            this._context = context;
        }
        public Student? GetStudent(int id)
        {
            return _context.Students.Find(id);
        }
        public int Edit(Student obj) 
        { 
            _context.Students.Update(obj);
            return _context.SaveChanges();
        }
        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
        public int Add(Student obj)
        {
            _context.Students.Add(obj);
            return _context.SaveChanges();
        }
        public int Delete(int id) 
        {
            //Student? obj = _context.Students.Find(id);
            Student? obj = GetStudent(id);
            if (obj != null)
            {
                _context.Students.Remove(obj);
                return _context.SaveChanges() ;//0 (ko xóa), 1 (xóa 1 dòng)
            }
            return -1;
        }
    }
}
