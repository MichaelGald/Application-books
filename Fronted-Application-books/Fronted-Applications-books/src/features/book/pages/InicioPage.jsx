import { Link } from 'react-router-dom';

export const InicioPage = () => {
  return(
      <main
        className="container mx-auto py-8 px-4 bg-gray-100 sm:px-6 "
      >
        <div className="grid grid-cols-1 gap-6 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="libro/" className="absolute inset-0 z-10" prefetch={false}> 
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
          {/* Repite la estructura de tarjeta de libro con los colores actualizados */}
          <div
            className="group relative rounded-lg border p-4 shadow-sm bg-white border-gray-300"
          >
            <Link to="#" className="absolute inset-0 z-10" prefetch={false}>
              <span className="sr-only">View book details</span>
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
              <button className="text-blue-500 hover:text-blue-700" size="icon">
                <PlusIcon className="h-5 w-5" />
                <span className="sr-only">Add to library</span>
              </button>
            </div>
          </div>
          {/* Repite para otros libros */}
        
        </div>
      </main>
  );
};

function PlusIcon(props) {
  return (
    <svg
      {...props}
      xmlns="http://www.w3.org/2000/svg"
      width="24"
      height="24"
      viewBox="0 0 24 24"
      fill="none"
      stroke="currentColor"
      strokeWidth="2"
      strokeLinecap="round"
      strokeLinejoin="round"
    >
      <path d="M5 12h14" />
      <path d="M12 5v14" />
    </svg>
  );
}
