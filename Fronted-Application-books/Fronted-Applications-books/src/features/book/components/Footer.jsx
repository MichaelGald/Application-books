import { Link } from "react-router-dom"

export const Footer = () => {
    return(
        <footer className="bg-blue-800 text-white py-6">
        <div className="container mx-auto px-4 sm:px-6">
          <div className="flex flex-col sm:flex-row justify-between">
            <div className="mb-4 sm:mb-0">
              <h4 className="text-lg font-semibold">Biblioteca VIP</h4>
              <p className="text-sm mt-1">
                &copy; 2024 Biblioteca VIP. Todos los derechos reservados.
              </p>
            </div>
            <div className="flex flex-col sm:flex-row gap-4">
              <Link to="inicio/" className="text-gray-200 hover:text-gray-400">
                Inicio
              </Link>
              <Link to="#" className="text-gray-200 hover:text-gray-400">
                Perfil
              </Link>
              <Link to="#" className="text-gray-200 hover:text-gray-400">
                Lista de favoritos
              </Link>
              <Link to="#" className="text-gray-200 hover:text-gray-400">
                Autores
              </Link>
            </div>
          </div>
        </div>
      </footer>
    )
}