import { Link } from 'react-router-dom';
import { Barra } from '../components';
import { FaPlus } from "react-icons/fa6";

export const InicioPage = () => {
  return(  
      <main className="container mx-auto py-6 px-4 bg-gray-100 sm:px-6">
        <div className="py-1">
         <Barra/>
        </div>
        <div className="py-3">
          <h2 className="text-3xl font-bold text-blue-600">Libros Recientes</h2>
        </div>
        <div className="grid grid-cols-1 gap-6 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 py-4">
          <div className="group relative rounded-lg border p-4 shadow-md bg-white border-gray-300">
            <Link to="/libro" className="absolute inset-0 z-10" prefetch={false}> 
            </Link>
            <div className="flex h-40 items-center justify-center">
              <img
                src="https://upload.wikimedia.org/wikipedia/commons/1/1c/El_principito.jpg"
                alt="Book cover"
                width={160}
                height={240}
                className="max-h-full max-w-full rounded-md object-contain"
                style={{ aspectRatio: '160/240', objectFit: 'cover' }}
              />
            </div>
            <div className="mt-4">
              <h3 className="text-lg font-semibold text-gray-900">
                El Principito
              </h3>
              <p className="text-sm text-gray-600">
                Ficción
              </p>
            </div>
            <div className="absolute top-2 right-2 hidden group-hover:flex">
              <button className="text-rose-500 " size="icon">
                <FaPlus className="h-5 w-5" />
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          <div className="group relative rounded-lg border p-4 shadow-md bg-white border-gray-300">
            <Link to="/libro" className="absolute inset-0 z-10" prefetch={false}>
            </Link>
            <div className="flex h-40 items-center justify-center">
              <img
                src="https://upload.wikimedia.org/wikipedia/commons/1/1c/El_principito.jpg"
                alt="Book cover"
                width={160}
                height={240}
                className="max-h-full max-w-full rounded-md object-contain"
                style={{ aspectRatio: '160/240', objectFit: 'cover' }}
              />
            </div>
            <div className="mt-4">
              <h3 className="text-lg font-semibold text-gray-900">
                The Great Gatsby
              </h3>
              <p className="text-sm text-gray-600">
                Fiction
              </p>
            </div>
            <div className="absolute top-2 right-2 hidden group-hover:flex">
              <button className="text-rose-500" size="icon">
                <FaPlus className="h-5 w-5" />
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
       
        </div>
      </main>
  );
};
