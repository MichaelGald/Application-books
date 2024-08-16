import { useState } from "react";
import { Link } from "react-router-dom";
import { CiMenuBurger } from "react-icons/ci";

export const Nav = () => {
    const [isMenuOpen, setIsMenuOpen] = useState(false);

    const handleMenuToggle = () => {
        setIsMenuOpen(!isMenuOpen);
    }

    const closeMenu = () => {
        setIsMenuOpen(false);
    }

    return (
        <nav className="px-6 py-4 bg-blue-500 shadow-md">
            <div className="container flex flex-col mx-auto md:flex-row md:items-center md:justify-between">
                <div className="flex items-center justify-between">
                    <div>
                        <Link to="/inicio" className="text-xl font-bold text-white md:text-2xl">
                            Biblioteca VIP
                        </Link>
                    </div>
                    <div>
                        <button
                            type="button"
                            onClick={handleMenuToggle}
                            className="block text-white hover:text-rose-500 md:hidden"
                        >
                            <CiMenuBurger className="w-6 h-6 fill-current" />
                        </button>
                    </div>
                </div>

                <div className={`${isMenuOpen ? "flex" : "hidden"} flex-col md:flex md:flex-row md:mx-4`}>
                    <Link to="/inicio" className="my-1 text-white hover:text-rose-500 md:mx-4 md:my-0" onClick={closeMenu}>
                        Inicio
                    </Link>
                    <Link to="#" className="my-1  text-white hover:text-rose-500 md:mx-4 md:my-0" onClick={closeMenu}>
                        Perfil
                    </Link>
                    <Link to="/favorito" className="my-1  text-white hover:text-rose-500 md:mx-4 md:my-0" onClick={closeMenu}>
                        Lista de Favoritos
                    </Link>
                </div>
            </div>
        </nav>
    );
}
