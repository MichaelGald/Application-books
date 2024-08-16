import { Navigate, Route, Routes } from "react-router-dom";
import { Footer, Nav } from "../components";
import { InicioPage } from "../pages/InicioPage";
import { AutorPage, FavoritosPage, LibroPage } from "../pages";

export const AppLibrosRouter = () => {
  return (
    <div className="overflow-x-hidden bg-gray-200 w-screen h-screen bg-hero-pattern bg-no-repeat bg-cover">
      <Nav />
      <div className="px-6 py-8">
        <div className="container mx-auto">
          <Routes>
            <Route path="/inicio" element={<InicioPage />} />
            <Route path="/libro" element={<LibroPage />} />
            <Route path="/autor" element={<AutorPage />} />
            <Route path="/favorito" element={<FavoritosPage />} />
            <Route path="/*" element={<Navigate to="/inicio" />} />
          </Routes>
        </div>
      </div>
      <Footer />
    </div>
  );
};

