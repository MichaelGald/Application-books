import { Link } from "react-router-dom";

export const AutorPage = () => {
  return (
    <div className="bg-gray-100 text-foreground min-h-dvh flex flex-col">
      <header className="bg-primary text-primary-foreground py-8 px-4 md:px-6">
        <div className="container mx-auto max-w-4xl">
          <h1 className="text-4xl font-bold text-blue-600">Antoine de Saint-Exupéry</h1>
          <div className="mt-4">
            <img
              src="https://www.biografiasyvidas.com/biografia/s/fotos/saint_exupery.jpg"
              alt="Antoine de Saint-Exupéry"
              width={200}
              height={200}
              className="rounded-full"
              style={{ aspectRatio: "200/200", objectFit: "cover" }}
            />
          </div>
        </div>
      </header>
      <main className="flex-1 py-0 px-4 md:px-6">
        <div className="container mx-auto max-w-4xl grid gap-8">
          <div className="grid gap-4">
            <h2 className="text-3xl font-bold text-blue-600">Biografía</h2>
            <p className="text-muted-foreground">
              Nació el 29 de junio de 1900. Quedó huérfano de padre a la
              temprana edad de 4 años y se crio en el entorno femenino de una
              familia aristocrática de la ciudad de Lyon (donde su madre
              trabajaba como enfermera). Terminó el bachillerato en 1917, en el
              colegio marianista Villa Saint-Jean de Friburgo (Suiza), y tras
              ser rechazado en la escuela naval, se hizo piloto cuando estaba
              cumpliendo el servicio militar en 1920, en Estrasburgo.
            </p>
            <p className="text-muted-foreground">
              No tardó en integrarse en la escuadrilla de pilotos que cubrían
              los tramos de «la Línea» que transportaba el correo entre
              Toulouse, Barcelona, Málaga, Tetuán, Sahara español, hasta las
              antiguas colonias francesas, en lo que luego fue Senegal. A
              finales de 1927 fue destinado como jefe de escala a Cabo Juby,
              entonces bajo administración española, donde inició con cierta
              constancia su vocación literaria. En 1928 se trasladó a
              Sudamérica. En 1929 se publicó Correo del Sur y a finales de 1930
              Vuelo nocturno, que le supuso un gran éxito al obtener el premio
              Femina; ambas obras giran en torno a sus experiencias como
              aviador.
            </p>
          </div>
          <div className="grid gap-4 py-2 px-0">
            <h2 className="text-3xl font-bold text-blue-600">Obras publicadas</h2>
            <div className="grid gap-6 sm:grid-cols-2 md:grid-cols-3">
              <div className="flex flex-col gap-2 px-10 py-3 bg-white items-start rounded">
                <Link to="/libro" prefetch={false}>
                  <img
                    src="https://upload.wikimedia.org/wikipedia/commons/1/1c/El_principito.jpg"
                    alt="El Principito"
                    width={200}
                    height={300}
                    className="rounded-lg"
                    style={{ aspectRatio: "200/300", objectFit: "cover" }}
                  />
                </Link>
                <div>
                  <h3 className="text-lg font-semibold">
                    <Link to="/libro" className="hover:underline hover:text-rose-500" prefetch={false}>
                      El Principito
                    </Link>
                  </h3>
                  <p className="text-muted-foreground">
                    La saga de la familia Buendía y el pueblo de Macondo, una de
                    las obras maestras del realismo mágico.
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </main>
    </div>
  );
};
