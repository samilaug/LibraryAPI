﻿using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface ILibraryItemRepository
    {
        Task<IEnumerable<LibraryItem>> GetAllAsync();
        Task<LibraryItem> GetByIdAsync(int id);
        Task AddAsync(LibraryItem libraryItem);
        void Update(LibraryItem libraryItem);
        void Delete(LibraryItem libraryItem);
        Task SaveChangesAsync();

        Task<IEnumerable<LibraryItem>> SearchByTitleAsync(string title);

        Task<IEnumerable<LibraryItem>> SearchByAuthorAndAvailabilityAsync(string author, AvailabilityStatus availabilityStatus);

    }
}
