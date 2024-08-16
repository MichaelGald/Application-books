import { useState } from "react";
import { Link } from "react-router-dom"

export const Footer = () => {
  const [year] = useState(new Date().getFullYear()); 
    return(
        <footer className="bg-blue-500  text-white py-6">
        <div className="container mx-auto px-4 sm:px-6">
          <div className="flex flex-col sm:flex-row justify-between">
            <div className="mb-4 sm:mb-0">
              <h4 className="text-lg font-semibold">Biblioteca VIP</h4>
              <p className="text-sm mt-1">
                &copy; {year} Biblioteca VIP. Todos los derechos reservados.
              </p>
            </div>
            <div className="flex flex-col sm:flex-row gap-4">
              <Link to="inicio/" className=" text-white hover:text-[#FF6F61]">
                Inicio
              </Link>
              <Link to="#" className=" text-white hover:text-[#FF6F61]">
                Perfil
              </Link>
              <Link to="#" className=" text-white hover:text-[#FF6F61]">
                Lista de favoritos
              </Link>
            </div>
          </div>
        </div>
      </footer>
    )
}
