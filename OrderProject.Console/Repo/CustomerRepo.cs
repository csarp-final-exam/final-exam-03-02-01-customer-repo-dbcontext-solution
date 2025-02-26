using Microsoft.EntityFrameworkCore;
using OrderProject.Console.Models;

namespace OrderProject.Console.Repo
{
    public class CustomerRepo
    {
        private readonly OrderContext _context = new OrderContext();

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
