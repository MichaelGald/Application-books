import { Route, Routes } from "react-router-dom"
import { Footer, Nav } from "../components"
import { InicioPage } from "../pages/InicioPage"
import { LibroPage } from "../pages"

export const AppLibrosRouter = () => {
    return(
        <div className="overflow-x-hidden bg-gray-100 w-screen h-screen bg-hero-pattern bg-no-repeat bg-cover">
        <Nav />
        <div className="px-6 py-8">
          <div className="container flex justify-between mx-auto">
            <Routes>
            <Route path= '/inicio' element={<InicioPage />} />
            <Route path= '/libro' element={<LibroPage />} />
            </Routes>
          </div>
        </div>
        <Footer />
      </div>
    )
}
