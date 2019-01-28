using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTecnico.Model
{
    public class CURP
    {
        #region Listas de valores.

        /// <summary>
        /// Estructura que representa la información de un estado.
        /// </summary>
        public struct Estado
        {
            public string EstadoID { get; set; }
            public string Nombre { get; set; }
        }

        /// <summary>
        /// Diccionario de palabras prohibidas con su respectiva sustitución.
        /// </summary>
        private Dictionary<string, string> palabraSustitucion;

        /// <summary>
        /// Lista de estados de nacimiento.
        /// </summary>
        public List<Estado> estados { get; set; }

        /// <summary>
        /// Lista de vocales.
        /// </summary>
        private List<char> vocales = (new char[] { 'A', 'E', 'I', 'O', 'U' }).ToList();

        /// <summary>
        /// Lista de consonantes.
        /// </summary>
        private List<char> consonantes = (new char[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' }).ToList();

        /// <summary>
        /// Lista de signos.
        /// </summary>
        private List<char> signos = (new char[] { '/', '\'', '.', '-' }).ToList();

        /// <summary>
        /// Lista de preposiciones.
        /// </summary>
        private List<string> preposiciones = (new string[] { "A", "ANTE", "BAJO", "CABE", "CON", "CONTRA", "DE", "DER", "DESDE", "DURANTE", "EN", "ENTRE", "HACIA", "HASTA", "MC", "MEDIANTE", "PARA", "POR", "SEGÚN", "SIN", "SO", "SOBRE", "TRAS", "VAN", "VERSUS", "VIA", "VON", "LA" }).ToList();

        /// <summary>
        /// Lista de conjunciones.
        /// </summary>
        private List<string> conjunciones = (new string[] { "CONQUE", "LUEGO", "TAN", "TANTO QUE", "ASÍ QUE", "POR LO TANTO", "Y", "E", "O", "U", "SINO", "TAL QUE", "PERO", "NI", "QUE" }).ToList();

        /// <summary>
        /// Lista de contracciones.
        /// </summary>
        private List<string> contracciones = (new string[] { "AL", "DEL", "LOS" }).ToList();

        #endregion

        #region Constructor de la clase.

        /// <summary>
        /// Constructor vacio.
        /// </summary>
        public CURP()
        {
            #region Inicialización de la lista de estados.

            estados = new List<Estado>();
            estados.Add(new Estado() { EstadoID = "NA", Nombre = "SELECCIONAR..." });
            estados.Add(new Estado() { EstadoID = "AS", Nombre = "AGUASCALIENTES" });
            estados.Add(new Estado() { EstadoID = "BC", Nombre = "BAJA CALIFORNIA" });
            estados.Add(new Estado() { EstadoID = "BS", Nombre = "BAJA CALIFORNIA SUR" });
            estados.Add(new Estado() { EstadoID = "CC", Nombre = "CAMPECHE" });
            estados.Add(new Estado() { EstadoID = "CL", Nombre = "COAHUILA" });
            estados.Add(new Estado() { EstadoID = "CM", Nombre = "COLIMA" });
            estados.Add(new Estado() { EstadoID = "CS", Nombre = "CHIAPAS" });
            estados.Add(new Estado() { EstadoID = "CH", Nombre = "CHIHUAHUA" });
            estados.Add(new Estado() { EstadoID = "DF", Nombre = "DISTRITO FEDERAL" });
            estados.Add(new Estado() { EstadoID = "DG", Nombre = "DURANGO" });
            estados.Add(new Estado() { EstadoID = "GT", Nombre = "GUANAJUATO" });
            estados.Add(new Estado() { EstadoID = "GR", Nombre = "GUERRERO" });
            estados.Add(new Estado() { EstadoID = "HG", Nombre = "HIDALGO" });
            estados.Add(new Estado() { EstadoID = "JC", Nombre = "JALISCO" });
            estados.Add(new Estado() { EstadoID = "MC", Nombre = "MEXICO" });
            estados.Add(new Estado() { EstadoID = "MN", Nombre = "MICHOACAN" });
            estados.Add(new Estado() { EstadoID = "MS", Nombre = "MORELOS" });
            estados.Add(new Estado() { EstadoID = "NT", Nombre = "NAYARIT" });
            estados.Add(new Estado() { EstadoID = "NL", Nombre = "NUEVO LEON" });
            estados.Add(new Estado() { EstadoID = "OC", Nombre = "OAXACA" });
            estados.Add(new Estado() { EstadoID = "PL", Nombre = "PUEBLA" });
            estados.Add(new Estado() { EstadoID = "QT", Nombre = "QUERETARO" });
            estados.Add(new Estado() { EstadoID = "QR", Nombre = "QUINTANA ROO" });
            estados.Add(new Estado() { EstadoID = "SP", Nombre = "SAN LUIS POTOSI" });
            estados.Add(new Estado() { EstadoID = "SL", Nombre = "SINALOA" });
            estados.Add(new Estado() { EstadoID = "SR", Nombre = "SONORA" });
            estados.Add(new Estado() { EstadoID = "TC", Nombre = "TABASCO" });
            estados.Add(new Estado() { EstadoID = "TS", Nombre = "TAMAULIPAS" });
            estados.Add(new Estado() { EstadoID = "TL", Nombre = "TLAXCALA" });
            estados.Add(new Estado() { EstadoID = "VZ", Nombre = "VERACRUZ" });
            estados.Add(new Estado() { EstadoID = "YN", Nombre = "YUCATAN" });
            estados.Add(new Estado() { EstadoID = "ZA", Nombre = "ZACATECAS" });
            estados.Add(new Estado() { EstadoID = "NE", Nombre = "NACIDO EN EL EXTRANJERO" });

            #endregion

            #region Inicialización de la lista de palabras de sustitución.
            palabraSustitucion = new Dictionary<string, string>();
            palabraSustitucion.Add("BACA", "BXCA");
            palabraSustitucion.Add("BAKA", "BXKA");
            palabraSustitucion.Add("BUEI", "BXEI");
            palabraSustitucion.Add("BUEY", "BXEY");
            palabraSustitucion.Add("CACA", "CXCA");
            palabraSustitucion.Add("CACO", "CXCO");
            palabraSustitucion.Add("CAGA", "CXGA");
            palabraSustitucion.Add("CAGO", "CXGO");
            palabraSustitucion.Add("CAKA", "CXKA");
            palabraSustitucion.Add("CAKO", "CXKO");
            palabraSustitucion.Add("COGE", "CXGE");
            palabraSustitucion.Add("COGI", "CXGI");
            palabraSustitucion.Add("COJA", "CXJA");
            palabraSustitucion.Add("COJE", "CXJE");
            palabraSustitucion.Add("COJI", "CXJI");
            palabraSustitucion.Add("COJO", "CXJO");
            palabraSustitucion.Add("COLA", "CXLA");
            palabraSustitucion.Add("CULO", "CXLO");
            palabraSustitucion.Add("FALO", "FXLO");
            palabraSustitucion.Add("FETO", "FXTO");
            palabraSustitucion.Add("GETA", "GXTA");
            palabraSustitucion.Add("GUEI", "GXEI");
            palabraSustitucion.Add("GUEY", "GXEY");
            palabraSustitucion.Add("JETA", "JXTA");
            palabraSustitucion.Add("JOTO", "JXTO");
            palabraSustitucion.Add("KACA", "KXCA");
            palabraSustitucion.Add("KACO", "KXCO");
            palabraSustitucion.Add("KAGA", "KXGA");
            palabraSustitucion.Add("KAGO", "KXGO");
            palabraSustitucion.Add("KAKA", "KXKA");
            palabraSustitucion.Add("KAKO", "KXKO");
            palabraSustitucion.Add("KOGE", "KXGE");
            palabraSustitucion.Add("KOGI", "KXGI");
            palabraSustitucion.Add("KOJA", "KXJA");
            palabraSustitucion.Add("KOJE", "KXJE");
            palabraSustitucion.Add("KOJI", "KXJI");
            palabraSustitucion.Add("KOJO", "KXJO");
            palabraSustitucion.Add("KOLA", "KXLA");
            palabraSustitucion.Add("KULO", "KXLO");
            palabraSustitucion.Add("LILO", "LXLO");
            palabraSustitucion.Add("LOCA", "LXCA");
            palabraSustitucion.Add("LOCO", "LXCO");
            palabraSustitucion.Add("LOKA", "LXKA");
            palabraSustitucion.Add("LOKO", "LXKO");
            palabraSustitucion.Add("MAME", "MXME");
            palabraSustitucion.Add("MAMO", "MXMO");
            palabraSustitucion.Add("MEAR", "MXAR");
            palabraSustitucion.Add("MEAS", "MXAS");
            palabraSustitucion.Add("MEON", "MXON");
            palabraSustitucion.Add("MIAR", "MXAR");
            palabraSustitucion.Add("MION", "MXON");
            palabraSustitucion.Add("MOCO", "MXCO");
            palabraSustitucion.Add("MOKO", "MXKO");
            palabraSustitucion.Add("MULA", "MXLA");
            palabraSustitucion.Add("MULO", "MXLO");
            palabraSustitucion.Add("NACA", "NXCA");
            palabraSustitucion.Add("NACO", "NXCO");
            palabraSustitucion.Add("PEDA", "PXDA");
            palabraSustitucion.Add("PEDO", "PXDO");
            palabraSustitucion.Add("PENE", "PXNE");
            palabraSustitucion.Add("PIPI", "PXPI");
            palabraSustitucion.Add("PITO", "PXTO");
            palabraSustitucion.Add("POPO", "PXPO");
            palabraSustitucion.Add("PUTA", "PXTA");
            palabraSustitucion.Add("PUTO", "PXTO");
            palabraSustitucion.Add("QULO", "QXLO");
            palabraSustitucion.Add("RATA", "RXTA");
            palabraSustitucion.Add("ROBA", "RXBA");
            palabraSustitucion.Add("ROBE", "RXBE");
            palabraSustitucion.Add("ROBO", "RXBO");
            palabraSustitucion.Add("RUIN", "RXIN");
            palabraSustitucion.Add("SENO", "SXNO");
            palabraSustitucion.Add("TETA", "TXTA");
            palabraSustitucion.Add("VACA", "VXCA");
            palabraSustitucion.Add("VAGA", "VXGA");
            palabraSustitucion.Add("VAGO", "VXGO");
            palabraSustitucion.Add("VAKA", "VXKA");
            palabraSustitucion.Add("VUEI", "VXEI");
            palabraSustitucion.Add("VUEY", "VXEY");
            palabraSustitucion.Add("WUEI", "WXEI");
            palabraSustitucion.Add("WUEY", "WXEY");
            #endregion
        }

        #endregion

        #region Método para obtener el CURP.

        /// <summary>
        /// Método para obtener el CURP.
        /// </summary>
        /// <param name="nombre">Nombre.</param>
        /// <param name="apellidoPaterno">Apellido paterno.</param>
        /// <param name="apellidoMaterno">Apellido materno.</param>
        /// <param name="sexo">Sexo ('H' o 'M').</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento (dd/MM/YYYY).</param>
        /// <param name="estadoID">Clave del estado de nacimiento.</param>
        /// <returns>Curp sin homoclave.</returns>
        public string ObtenCurp(string nombre, string apellidoPaterno, string apellidoMaterno, char sexo, string fechaNacimiento, string estadoID)
        {
            try
            {
                string _curp = string.Empty;
                List<string> _elementosApellidoPaterno = new List<string>();
                List<char> _caracteresApellidoPaterno = new List<char>();
                List<string> _elementosApellidoMaterno = new List<string>();
                List<string> _elementosNombre = new List<string>();
                bool _tieneApellidoMaterno = true;

                #region Posición 1 y 2
                List<string> _elementos = apellidoPaterno.Trim().ToUpper().Split(' ').ToList();

                #region Descarta los elementos del apellidoPaterno que son preposiciones, conjunciones o contracciones
                foreach (string e in _elementos)
                {
                    if (!preposiciones.Exists(x => x.Equals(e)) && !conjunciones.Exists(x => x.Equals(e)) && !contracciones.Exists(x => x.Equals(e)))
                        _elementosApellidoPaterno.Add(e);
                }
                #endregion

                if (_elementosApellidoPaterno.Count > 0)
                {
                    if (_elementosApellidoPaterno[0][0].Equals('Ñ'))
                        _curp += "X";
                    else if (signos.Exists(x => x.Equals(_elementosApellidoPaterno[0][0])))
                        _curp += "X";
                    else
                        _curp += _elementosApellidoPaterno[0][0];

                    _elementosApellidoPaterno[0] = _elementosApellidoPaterno[0].Remove(0, 1);

                    _caracteresApellidoPaterno = _elementosApellidoPaterno[0].ToCharArray().ToList();

                    for (int i = 0; i < _caracteresApellidoPaterno.Count; i++)
                    {
                        if (i == _caracteresApellidoPaterno.Count - 1)
                        {
                            if (vocales.Exists(x => x.Equals(_caracteresApellidoPaterno[i])))
                            {
                                _curp += _caracteresApellidoPaterno[i].ToString();
                                break;
                            }
                            else
                            {
                                _curp += "X";
                                break;
                            }
                        }
                        else if (vocales.Exists(x => x.Equals(_caracteresApellidoPaterno[i])))
                        {
                            _curp += _caracteresApellidoPaterno[i].ToString();
                            break;
                        }
                    }
                }
                else
                    return string.Empty;
                #endregion

                #region Posición 3
                if (string.IsNullOrEmpty(apellidoMaterno) || string.IsNullOrWhiteSpace(apellidoMaterno))
                {
                    _curp += "X";
                    _tieneApellidoMaterno = false;
                }
                else
                {
                    _elementos = apellidoMaterno.Trim().ToUpper().Split(' ').ToList();

                    #region Descarta los elementos del apellidoMaterno que son preposiciones, conjunciones o contracciones
                    foreach (string e in _elementos)
                    {
                        if (!preposiciones.Exists(x => x.Equals(e)) && !conjunciones.Exists(x => x.Equals(e)) && !contracciones.Exists(x => x.Equals(e)))
                            _elementosApellidoMaterno.Add(e);
                    }
                    #endregion

                    if (_elementosApellidoMaterno.Count > 0)
                    {
                        if (_elementosApellidoMaterno[0][0].Equals('Ñ'))
                            _curp += "X";
                        else if (signos.Exists(x => x.Equals(_elementosApellidoMaterno[0][0])))
                            _curp += "X";
                        else
                            _curp += _elementosApellidoMaterno[0][0];
                    }
                    else
                        return string.Empty;
                }
                #endregion

                #region Posición 4
                _elementos = nombre.Trim().ToUpper().Split(' ').ToList();

                #region Descarta los elementos del nombre que son preposiciones, conjunciones o contracciones
                foreach (string e in _elementos)
                {
                    if (!preposiciones.Exists(x => x.Equals(e)) && !conjunciones.Exists(x => x.Equals(e)) && !contracciones.Exists(x => x.Equals(e)))
                        _elementosNombre.Add(e);
                }
                #endregion

                if (_elementosNombre.Count > 0)
                {
                    if (_elementosNombre.Count == 2 && (_elementosNombre[0].Equals("MARIA") || _elementosNombre[0].Equals("MA.") || _elementosNombre[0].Equals("MA") || _elementosNombre[0].Equals("JOSE") || _elementosNombre[0].Equals("J.") || _elementosNombre[0].Equals("J")))
                    {
                        if (_elementosNombre[1][0].Equals('Ñ'))
                            _curp += "X";
                        else if (signos.Exists(x => x.Equals(_elementosNombre[1][0])))
                            _curp += "X";
                        else
                            _curp += _elementosNombre[1][0];
                    }
                    else
                    {
                        if (_elementosNombre[0][0].Equals('Ñ'))
                            _curp += "X";
                        else if (signos.Exists(x => x.Equals(_elementosNombre[0][0])))
                            _curp += "X";
                        else
                            _curp += _elementosNombre[0][0];
                    }
                }
                else
                    return string.Empty;
                #endregion

                #region Cambia las posiciones de la 1 a la 4 si es palabra inconveniente
                if (palabraSustitucion.ContainsKey(_curp))
                    _curp = palabraSustitucion[_curp];
                #endregion

                #region Posición 5 a 10
                fechaNacimiento = fechaNacimiento.Replace("/", "");
                _curp += string.Format("{0}{1}{2}", fechaNacimiento.Substring(6, 2), fechaNacimiento.Substring(2, 2), fechaNacimiento.Substring(0, 2));
                #endregion

                #region Posición 11
                _curp += sexo.ToString().ToUpper();
                #endregion

                #region Posición 12 y 13
                _curp += estadoID;
                #endregion

                #region Posición 14, 15, 16
                for (int i = 0; i < _caracteresApellidoPaterno.Count; i++)
                {
                    if (i == _caracteresApellidoPaterno.Count - 1)
                    {
                        if (consonantes.Exists(x => x.Equals(_caracteresApellidoPaterno[i])))
                        {
                            if (_caracteresApellidoPaterno[i].Equals('Ñ'))
                                _curp += "X";
                            else
                                _curp += _caracteresApellidoPaterno[i].ToString();
                            break;
                        }
                        else
                        {
                            _curp += "X";
                            break;
                        }
                    }
                    else if (consonantes.Exists(x => x.Equals(_caracteresApellidoPaterno[i])))
                    {
                        if (_caracteresApellidoPaterno[i].Equals('Ñ'))
                            _curp += "X";
                        else
                            _curp += _caracteresApellidoPaterno[i].ToString();
                        break;
                    }
                }

                if (!_tieneApellidoMaterno)
                    _curp += "X";
                else
                {
                    _elementosApellidoMaterno[0] = _elementosApellidoMaterno[0].Remove(0, 1);
                    List<char> _caracteresApellidoMaterno = _elementosApellidoMaterno[0].ToCharArray().ToList();

                    for (int i = 0; i < _caracteresApellidoMaterno.Count; i++)
                    {
                        if (i == _caracteresApellidoMaterno.Count - 1)
                        {
                            if (consonantes.Exists(x => x.Equals(_caracteresApellidoMaterno[i])))
                            {
                                if (_caracteresApellidoMaterno[i].Equals('Ñ'))
                                    _curp += "X";
                                else
                                    _curp += _caracteresApellidoMaterno[i].ToString();
                                break;
                            }
                            else
                            {
                                _curp += "X";
                                break;
                            }
                        }
                        else if (consonantes.Exists(x => x.Equals(_caracteresApellidoMaterno[i])))
                        {
                            if (_caracteresApellidoMaterno[i].Equals('Ñ'))
                                _curp += "X";
                            else
                                _curp += _caracteresApellidoMaterno[i].ToString();
                            break;
                        }
                    }
                }


                if (_elementosNombre.Count == 2 && (_elementosNombre[0].Equals("MARIA") || _elementosNombre[0].Equals("MA.") || _elementosNombre[0].Equals("MA") || _elementosNombre[0].Equals("JOSE") || _elementosNombre[0].Equals("J.") || _elementosNombre[0].Equals("J")))
                {
                    _elementosNombre[1] = _elementosNombre[1].Remove(0, 1);

                    List<char> _caracteresNombre = _elementosNombre[1].ToCharArray().ToList();

                    for (int i = 0; i < _caracteresNombre.Count; i++)
                    {
                        if (i == _caracteresNombre.Count - 1)
                        {
                            if (consonantes.Exists(x => x.Equals(_caracteresNombre[i])))
                            {
                                if (_caracteresNombre[i].Equals('Ñ'))
                                    _curp += "X";
                                else
                                    _curp += _caracteresNombre[i].ToString();
                                break;
                            }
                            else
                            {
                                _curp += "X";
                                break;
                            }
                        }
                        else if (consonantes.Exists(x => x.Equals(_caracteresNombre[i])))
                        {
                            if (_caracteresNombre[i].Equals('Ñ'))
                                _curp += "X";
                            else
                                _curp += _caracteresNombre[i].ToString();
                            break;
                        }
                    }
                }
                else
                {
                    _elementosNombre[0] = _elementosNombre[0].Remove(0, 1);

                    List<char> _caracteresNombre = _elementosNombre[0].ToCharArray().ToList();

                    for (int i = 0; i < _caracteresNombre.Count; i++)
                    {
                        if (i == _caracteresNombre.Count - 1)
                        {
                            if (consonantes.Exists(x => x.Equals(_caracteresNombre[i])))
                            {
                                if (_caracteresNombre[i].Equals('Ñ'))
                                    _curp += "X";
                                else
                                    _curp += _caracteresNombre[i].ToString();
                                break;
                            }
                            else
                            {
                                _curp += "X";
                                break;
                            }
                        }
                        else if (consonantes.Exists(x => x.Equals(_caracteresNombre[i])))
                        {
                            if (_caracteresNombre[i].Equals('Ñ'))
                                _curp += "X";
                            else
                                _curp += _caracteresNombre[i].ToString();
                            break;
                        }
                    }
                }

                #endregion
                return _curp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
    }
}
