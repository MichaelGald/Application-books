import { Link } from "react-router-dom";
import { BsHeart } from "react-icons/bs";
import { useState } from "react";

export const FavoritosPage = () => {
  const userFavoriteBooks = [
    {
      title: "El Principito",
      author: "Antoine de Saint-Exupéry",
      image: "https://upload.wikimedia.org/wikipedia/commons/1/1c/El_principito.jpg",
      link: "/libro/el-principito",
    },
  ];
  const [isFavorite, setIsFavorite] = useState(false);

  const handleFavoriteClick = () => {
    setIsFavorite(!isFavorite);
  };

  return (
    <div className="container mx-auto px-4 py-12 bg-gray-100">
      <div className="max-w-3xl mx-auto">
        <h1 className="text-3xl font-bold mb-2">Mis Libros Favoritos</h1>
        <p className="text-muted-foreground mb-8">
          Aquí está su lista de favoritos para que tenga una mayor facilitad de ir buscar sus libros preferidos.
        </p>
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-8">
          {userFavoriteBooks.map((book, index) => (
            <div key={index} className="bg-card rounded-lg overflow-hidden shadow-lg">
              <Link to="/libro">
                <img
                  src={book.image}
                  alt={book.title}
                  width={400}
                  height={500}
                  className="w-full h-60 object-cover"
                  style={{ aspectRatio: "400/500", objectFit: "cover" }}
                />
              </Link>
              <div className="p-4">
                <Link to="/libro">
                  <h3 className="text-lg font-semibold mb-2 hover:underline">
                    {book.title}
                  </h3>
                </Link>
                <p className="text-muted-foreground mb-4">{book.author}</p>
                <button
              type="button"
              className={`flex items-center h-9 mt-4 sm:mt-0 text-blue-600 hover:text-blue-800 transition-colors duration-200 ${
                isFavorite ? 'text-rose-500' : ''
              }`}
              onClick={handleFavoriteClick}
            >
              <BsHeart className={`w-4 h-4 mr-2 transition-transform duration-200 transform hover:scale-125 ${
                isFavorite ? 'fill-current text-rose-500' : ''
              }`} />
              {isFavorite ? 'Favorito' : 'Agregar a Favoritos'}
            </button>
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

