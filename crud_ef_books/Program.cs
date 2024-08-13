using crud_ef_books;
using (var context = new LibraryContext()){
    var newBook = new Book{
        Title = "The Pragmatic Programmer",
        Author = "Andrew Hunt",
        PublishedYear = 1999,
        Genre = "Software Development",
        Price = 39.99m
    };
    context.Books.Add(newBook);
    context.SaveChanges();
}
using (var context = new LibraryContext()){
    var books = context.Books.ToList();
    foreach (var book in books){
        Console.WriteLine(
            $"{book.Title} by {book.Author}, " +
            $"Published in {book.PublishedYear}, " +
            $"Genre: {book.Genre}, " +
            $"Price: {book.Price}");
    }
}
/*using (var context = new LibraryContext()){
    var book = context.Books.FirstOrDefault(b => b.BookId == 1);
    if (book != null){
        book.Price = 39.99m; // Actualizamos el precio
        context.SaveChanges();
    }
}*/