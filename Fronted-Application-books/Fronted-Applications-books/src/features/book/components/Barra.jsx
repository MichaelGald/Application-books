import { useRef } from "react";
import { Link } from "react-router-dom";
import { CiSearch } from "react-icons/ci";
import { FaArrowRight, FaArrowLeft } from "react-icons/fa";

export const Barra = () => {
  const scrollRef = useRef(null);

  const scrollLeft = () => {
    scrollRef.current.scrollBy({ left: -300, behavior: "smooth" });
  };

  const scrollRight = () => {
    scrollRef.current.scrollBy({ left: 300, behavior: "smooth" });
  };

  const librosDestacados = [
    {
      titulo: "El Principito",
      imagen: "https://upload.wikimedia.org/wikipedia/commons/1/1c/El_principito.jpg",
      link: "/libro/el-principito",
    },
  ];

  return (
    <div className="py-4">
      <div className="flex items-center mb-6 md:mb-8 text-gray-900">
        <div className="relative flex-1">
          <CiSearch className="absolute left-3 top-1/2 -translate-y-1/2 w-5 h-5 text-gray-500" />
          <input
            type="search"
            placeholder="Buscar libros"
            className="w-full pl-10 pr-4 py-2 rounded-md bg-white text-blue-600 placeholder-blue-600 focus:outline-none focus:ring-2 focus:ring-rose-500"
          />
        </div>
        <button className="ml-4 px-4 py-2 bg-rose-500 text-white rounded-md hover:bg-rose-500">
          Buscar
        </button>
      </div>
      <div className="py-3">
        <h1 className="text-3xl font-bold text-blue-600">Libros destacados</h1>
      </div>
      <div className="relative">
        <button
          onClick={scrollLeft}
          className="absolute left-0 top-1/2 -translate-y-1/2 bg-rose-500 p-2 rounded-full shadow-md z-10 hover:bg-rose-500"
        >
          <FaArrowLeft />
        </button>
        <div
          ref={scrollRef}
          className="flex overflow-x-auto space-x-6 px-8"
          style={{ scrollbarWidth: 'none', msOverflowStyle: 'none' }}
        >
          {librosDestacados.map((libro, index) => (
            <Link
              key={index}
              to="/libro"
              className="flex-none w-60 group relative overflow-hidden rounded-lg shadow-lg"
            >
              <img
                src={libro.imagen}
                alt={libro.titulo}
                className="w-full h-auto object-cover transition-transform duration-500 ease-in-out group-hover:scale-110"
                style={{ aspectRatio: '3/4', objectFit: 'cover' }}
              />
              <div className="absolute inset-0 bg-gradient-to-t from-black to-transparent flex items-end p-4">
                <div className="text-white font-bold text-xl">{libro.titulo}</div>
              </div>
            </Link>
          ))}
        </div>
        <button
          onClick={scrollRight}
          className="absolute right-0 top-1/2 -translate-y-1/2 bg-rose-500 p-2 rounded-full shadow-md z-10 hover:bg-rose-500"
        >
          <FaArrowRight />
        </button>
      </div>
    </div>
  );
};
