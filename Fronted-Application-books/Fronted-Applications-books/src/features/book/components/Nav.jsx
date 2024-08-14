import { useState } from "react";
import { Link } from "react-router-dom";

export const Nav = () => {
    const [isMenuOpen, setMenuOpen] = useState(false);

    const toggleMenu = () => setMenuOpen(prevState => !prevState);
  
    return (
 
        <header
          className="flex items-center justify-between px-4 py-3 shadow-sm sm:px-6 relative bg-blue-800 text-white"
        >
          <Link
            to="inicio/"
            className="flex items-center gap-2 font-semibold"
            prefetch={false}
          >
            <BookIcon className="h-6 w-6" />
            <span>Biblioteca VIP</span>
          </Link>
          <div className="relative">
            <button
              className="text-white hover:text-gray-300"
              size="icon"
              onClick={toggleMenu}
            >
              <MenuIcon className="h-6 w-6" />
              <span className="sr-only">Open menu</span>
            </button>
            {isMenuOpen && (
              <div
                className="dropdown-menu-content absolute right-0 top-12 w-64 border border-gray-300 rounded-lg shadow-lg z-50 bg-white"
              >
                <div className="dropdown-menu-item px-4 py-2 hover:bg-gray-100">
                  <Link to="#" prefetch={false} className="block text-gray-800">
                    Inicio
                  </Link>
                </div>
                <div className="dropdown-menu-item px-4 py-2 hover:bg-gray-100">
                  <Link to="#" prefetch={false} className="block text-gray-800">
                    Perfil
                  </Link>
                </div>
                <div className="dropdown-menu-separator border-t border-gray-200" />
                <div className="dropdown-menu-item px-4 py-2 hover:bg-gray-100">
                  <Link to="#" prefetch={false} className="block text-gray-800">
                    Lista de Favoritos
                  </Link>
                </div>
                <div className="dropdown-menu-item px-4 py-2 hover:bg-gray-100">
                  <Link to="#" prefetch={false} className="block text-gray-800">
                    Autores
                  </Link>
                </div>
              </div>
            )}
          </div>
        </header>
 );
}
function MenuIcon(props) {
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
        <line x1="4" x2="20" y1="12" y2="12" />
        <line x1="4" x2="20" y1="6" y2="6" />
        <line x1="4" x2="20" y1="18" y2="18" />
      </svg>
    );
  }
  function BookIcon(props) {
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
        <path d="M4 19.5v-15A2.5 2.5 0 0 1 6.5 2H20v20H6.5a2.5 2.5 0 0 1 0-5H20" />
      </svg>
    );
  }