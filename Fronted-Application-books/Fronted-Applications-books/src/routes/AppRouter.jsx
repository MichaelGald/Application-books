import { Route, Routes } from "react-router-dom"
import { AppLibrosRouter } from "../features/book/routes/AppLibrosRouter"

export const AppRouter = () => {
 return(
    <Routes>
        <Route path="*" element={<AppLibrosRouter/>}/>
    </Routes>
 )
}