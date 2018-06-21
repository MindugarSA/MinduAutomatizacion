//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Security;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.VisualBasic;

//namespace PresentationLayer.Controls
//{


//    public class TimerAnimation : Timer
//    {
//        private object _Objet;
//        private string _NomPropriete;
//        private TypeTransition _Type;
//        private int _Debut;
//        private int _Fin;
//        private int _Duree; // Exprimée en millisecondes
//        private int _ActionParSeconde;

//        private double t;
//        private int NombreIteration;
//        private int IterationEnCours;
//        private int Change;

//        public int Debut
//        {
//            get
//            {
//                return _Debut;
//            }
//            set
//            {
//                _Debut = value;
//            }
//        }

//        public int Fin
//        {
//            get
//            {
//                return _Fin;
//            }

//            set
//            {
//                _Fin = value;

//                Change = _Fin - _Debut;
//            }
//        }

//        public int Duree
//        {
//            get
//            {
//                return _Duree;
//            }
//            set
//            {
//                _Duree = value;

//                NombreIteration = (int)Math.Round(_Duree / (double)_ActionParSeconde, 0);
//            }
//        }

//        public int ActionParSeconde
//        {
//            get
//            {
//                return _ActionParSeconde;
//            }

//            set
//            {
//                _ActionParSeconde = value;

//                this.Interval = _ActionParSeconde;

//                NombreIteration = (int)Math.Round(_Duree / (double)_ActionParSeconde, 0);
//            }
//        }

//        public TypeTransition Type
//        {
//            get
//            {
//                return _Type;
//            }

//            set
//            {
//                _Type = value;
//            }
//        }

//        public object Objet
//        {
//            get
//            {
//                return _Objet;
//            }

//            set
//            {
//                _Objet = value;
//            }
//        }

//        public string NomPropriete
//        {
//            get
//            {
//                return _NomPropriete;
//            }

//            set
//            {
//                _NomPropriete = value;
//            }
//        }

//        public void Transition(object m_objet, string m_NomPropriete, TypeTransition m_Type, int m_Debut, int m_Fin, int m_Duree)
//        {
//            this.Objet = m_objet;
//            this.NomPropriete = m_NomPropriete;
//            this.Type = m_Type;
//            this.Debut = m_Debut;
//            this.Fin = m_Fin;
//            this.Duree = m_Duree;

//            this.Tick += ActualiserPropriete;

//            this.Start();
//        }

//        private void ActualiserPropriete()
//        {
//            this.Actualiser();

//            Interaction.CallByName(_Objet, _NomPropriete, CallType.Set, this.Easing());
//        }

//        public TimerAnimation()
//        {

//            // Par défaut 
//            ActionParSeconde = 20;
//            IterationEnCours = 0;
//            this.Enabled = true;
//        }

//        public void Actualiser()
//        {
//            IterationEnCours = IterationEnCours + 1;

//            t = this.IterationEnCours / (double)this.NombreIteration;
//        }

//        public double Easing()
//        {
//            if (IterationEnCours > NombreIteration)
//                this.Stop();

//            Easing = EasingFunctions(_Type, t, Debut, Change, 1);
//        }

//        enum TypeTransition
//        {
//            easeInBack,
//            easeInBounce,
//            easeOutBounce,
//            easeInOutBounce,
//            easeInCirc,
//            easeInCubic,
//            easeInElastic,
//            easeInExpo,
//            easeInOutBack,
//            easeInOutCirc,
//            easeInOutCubic,
//            easeInOutElastic,
//            easeInOutExpo,
//            easeInOutQuad,
//            easeInOutQuart,
//            easeInOutQuint,
//            easeInOutSine,
//            easeInQuad,
//            easeInQuart,
//            easeInQuint,
//            easeInSine,
//            easeOutBack,
//            easeOutCirc,
//            easeOutCubic,
//            easeOutElastic,
//            easeOutExpo,
//            easeOutQuad,
//            easeOutQuart,
//            easeOutQuint,
//            easeOutSine
//        }

//        public static double EasingFunctions(string mode, double t, double b, double c, double d)
//        {
//            switch ((mode))
//            {
//                case TypeTransition.easeInBack:
//                    {
//                        EasingFunctions = easeInBack(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInBounce:
//                    {
//                        EasingFunctions = easeInBounce(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutBounce:
//                    {
//                        EasingFunctions = easeOutBounce(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutBounce:
//                    {
//                        EasingFunctions = easeInOutBounce(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInCirc:
//                    {
//                        EasingFunctions = easeInCirc(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInCubic:
//                    {
//                        EasingFunctions = easeInCubic(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInElastic:
//                    {
//                        EasingFunctions = easeInElastic(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInExpo:
//                    {
//                        EasingFunctions = easeInExpo(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutBack:
//                    {
//                        EasingFunctions = easeInOutBack(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutCirc:
//                    {
//                        EasingFunctions = easeInOutCirc(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutCubic:
//                    {
//                        EasingFunctions = easeInOutCubic(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutElastic:
//                    {
//                        EasingFunctions = easeInOutElastic(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutExpo:
//                    {
//                        EasingFunctions = easeInOutExpo(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutQuad:
//                    {
//                        EasingFunctions = easeInOutQuad(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutQuart:
//                    {
//                        EasingFunctions = easeInOutQuart(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutQuint:
//                    {
//                        EasingFunctions = easeInOutQuint(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInOutSine:
//                    {
//                        EasingFunctions = easeInOutSine(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInQuad:
//                    {
//                        EasingFunctions = easeInQuad(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInQuart:
//                    {
//                        EasingFunctions = easeInQuart(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInQuint:
//                    {
//                        EasingFunctions = easeInQuint(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeInSine:
//                    {
//                        EasingFunctions = easeInSine(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutBack:
//                    {
//                        EasingFunctions = easeOutBack(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutCirc:
//                    {
//                        EasingFunctions = easeOutCirc(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutCubic:
//                    {
//                        EasingFunctions = easeOutCubic(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutElastic:
//                    {
//                        EasingFunctions = easeOutElastic(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutExpo:
//                    {
//                        EasingFunctions = easeOutExpo(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutQuad:
//                    {
//                        EasingFunctions = easeOutQuad(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutQuart:
//                    {
//                        EasingFunctions = easeOutQuart(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutQuint:
//                    {
//                        EasingFunctions = easeOutQuint(t, b, c, d);
//                        return;
//                    }

//                case TypeTransition.easeOutSine:
//                    {
//                        EasingFunctions = easeOutSine(t, b, c, d);
//                        return;
//                    }

//                default:
//                    {
//                        EasingFunctions = -1;
//                        break;
//                    }
//            }
//        }

//        public static double easeInQuad(double t, double b, double c, double d)
//        {
//            t = t / d;
//            easeInQuad = c * t * t + b;
//        }

//        public static double easeOutQuad(double t, double b, double c, double d)
//        {
//            t = t / d;
//            easeOutQuad = -c * t * (t - 2) + b;
//        }

//        public static double easeInOutQuad(double t, double b, double c, double d)
//        {
//            t = 2 * t / d;

//            if (t < 1)
//                // 
//                easeInOutQuad = (c / 2) * t * t + b;
//            else
//            {
//                t = t - 1;

//                easeInOutQuad = -c / 2 * (t * (t - 2) - 1) + b;
//            }
//        }

//        public static double easeInCubic(double t, double b, double c, double d)
//        {
//            t = t / d;
//            easeInCubic = c * (t) * t * t + b;
//        }

//        public static double easeOutCubic(double t, double b, double c, double d)
//        {
//            t = (t / d) - 1;

//            easeOutCubic = c * (t * t * t + 1) + b;
//        }

//        public static double easeInOutCubic(double t, double b, double c, double d)
//        {
//            t = 2 * t / d;
//            if ((t < 1))
//                easeInOutCubic = c / 2 * t * t * t + b;
//            else
//            {
//                t = t - 2;
//                easeInOutCubic = c / 2 * (t * t * t + 2) + b;
//            }
//        }

//        public static double easeInQuart(double t, double b, double c, double d)
//        {
//            t = t / d;
//            easeInQuart = c * t * t * t * t + b;
//        }

//        public static double easeOutQuart(double t, double b, double c, double d)
//        {
//            t = t / d - 1;
//            easeOutQuart = -c * ((t * t * t * t) - 1) + b;
//        }

//        public static double easeInOutQuart(double t, double b, double c, double d)
//        {
//            t = 2 * t / d;

//            if ((t < 1))
//                easeInOutQuart = c / 2 * t * t * t * t + b;
//            else
//            {
//                t = t - 2;
//                easeInOutQuart = -c / 2 * (t * t * t * t - 2) + b;
//            }
//        }

//        public static double easeInQuint(double t, double b, double c, double d)
//        {
//            t = t / d;
//            easeInQuint = c * t * t * t * t * t + b;
//        }

//        public static double easeOutQuint(double t, double b, double c, double d)
//        {
//            t = t / d - 1;
//            easeOutQuint = c * (t * t * t * t * t + 1) + b;
//        }

//        public static double easeInOutQuint(double t, double b, double c, double d)
//        {
//            t = 2 * t / d;
//            if ((t < 1))
//                easeInOutQuint = c / 2 * t * t * t * t * t + b;
//            else
//            {
//                t = t - 2;
//                easeInOutQuint = c / 2 * (t * t * t * t * t + 2) + b;
//            }
//        }

//        public static double easeInSine(double t, double b, double c, double d)
//        {
//            easeInSine = -c * Math.Cos((t / d) * (Math.PI / 2)) + c + b;
//        }

//        public static double easeOutSine(double t, double b, double c, double d)
//        {
//            easeOutSine = c * Math.Sin(t / d * (Math.PI / 2)) + b;
//        }

//        public static double easeInOutSine(double t, double b, double c, double d)
//        {
//            easeInOutSine = -c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b;
//        }

//        public static double easeInExpo(double t, double b, double c, double d)
//        {
//            if (t == 0)
//                easeInExpo = b;
//            else
//                easeInExpo = c * Math.Pow(2, 10 * (t / d - 1)) + b;
//        }

//        public static double easeOutExpo(double t, double b, double c, double d)
//        {
//            if (t == d)
//                easeOutExpo = b + c;
//            else
//                easeOutExpo = c * (-Math.Pow(2, -10 * t / d) + 1) + b;
//        }

//        public static double easeInOutExpo(double t, double b, double c, double d)
//        {
//            if (t == 0)
//            {
//                easeInOutExpo = b;
//                return;
//            }

//            if (t == d)
//            {
//                easeInOutExpo = b + c;
//                return;
//            }

//            t = 2 * t / d;
//            if (t < 1)
//                easeInOutExpo = c / 2 * Math.Pow(2, 10 * (t - 1)) + b;
//            else
//            {
//                t = t - 1;
//                easeInOutExpo = c / 2 * (-Math.Pow(2, -10 * t) + 2) + b;
//            }
//        }

//        public static double easeInCirc(double t, double b, double c, double d)
//        {
//            t = t / d;
//            easeInCirc = -c * (Math.Sqrt(1 - (t * t)) - 1) + b;
//        }

//        public static double easeOutCirc(double t, double b, double c, double d)
//        {
//            t = t / d - 1;
//            easeOutCirc = c * Math.Sqrt(1 - (t * t)) + b;
//        }

//        public static double easeInOutCirc(double t, double b, double c, double d)
//        {
//            t = 2 * t / d;
//            if (t < 1)
//                easeInOutCirc = -c / 2 * (Math.Sqrt(1 - t * t) - 1) + b;
//            else
//            {
//                t = t - 2;
//                easeInOutCirc = c / 2 * (Math.Sqrt(1 - t * t) + 1) + b;
//            }
//        }

//        public static double easeInElastic(double t, double b, double c, double d)
//        {
//            double s = 1.70158;
//            double p = 0;
//            double a = c;

//            if (t == 0)
//            {
//                easeInElastic = b;
//                return;
//            }

//            t = t / d;
//            if (t == 1)
//            {
//                easeInElastic = b + c;
//                return;
//            }

//            p = d * 0.3;

//            if ((a < Math.Abs(c)))
//            {
//                a = c;
//                s = p / 4;
//            }
//            else
//                s = p / (2 * Math.PI) * Math.Asin(c / a);

//            t = t - 1;
//            easeInElastic = -(a * Math.Pow(2, 10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
//        }

//        public static double easeOutElastic(double t, double b, double c, double d)
//        {
//            double s = 1.70158;
//            double p = 0;
//            double a = c;

//            if (t == 0)
//            {
//                easeOutElastic = b;
//                return;
//            }

//            t = t / d;
//            if (t == 1)
//            {
//                easeOutElastic = b + c;
//                return;
//            }

//            p = d * 0.3;

//            if ((a < Math.Abs(c)))
//            {
//                a = c;
//                s = p / 4;
//            }
//            else
//                s = p / (2 * Math.PI) * Math.Asin(c / a);

//            easeOutElastic = a * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p) + c + b;
//        }

//        public static double easeInOutElastic(double t, double b, double c, double d)
//        {
//            double s = 1.70158;
//            double p = 0;
//            double a = c;

//            if (t == 0)
//            {
//                easeInOutElastic = b;
//                return;
//            }

//            t = 2 * t / d;
//            if (t == 2)
//            {
//                easeInOutElastic = b + c;
//                return;
//            }

//            p = d * 0.3 * 1.5;

//            if ((a < Math.Abs(c)))
//            {
//                a = c;
//                s = p / 4;
//            }
//            else
//                s = p / (2 * Math.PI) * Math.Asin(c / a);

//            if (t < 1)
//            {
//                t = t - 1;
//                easeInOutElastic = -0.5 * (a * Math.Pow(2, 10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
//            }
//            else
//            {
//                t = t - 1;
//                easeInOutElastic = a * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p) * 0.5 + c + b;
//            }
//        }

//        public static double easeInBack(double t, double b, double c, double d)
//        {
//            double s;
//            s = 1.70158;
//            t = t / d;
//            easeInBack = c * t * t * ((s + 1) * t - s) + b;
//        }

//        public static double easeOutBack(double t, double b, double c, double d)
//        {
//            double s;
//            s = 1.70158;
//            t = t / d - 1;
//            easeOutBack = c * (t * t * ((s + 1) * t + s) + 1) + b;
//        }

//        public static double easeInOutBack(double t, double b, double c, double d)
//        {
//            double s;
//            s = 1.70158;

//            t = 2 * t / d;

//            if (t < 1)
//            {
//                s = s * 1.525;
//                easeInOutBack = c / 2 * (t * t * (((s) + 1) * t - s)) + b;
//            }
//            else
//            {
//                t = t - 2;
//                easeInOutBack = c / 2 * ((t) * t * (((s) + 1) * t + s) + 2) + b;
//            }
//        }

//        public static double easeInBounce(double t, double b, double c, double d)
//        {
//            easeInBounce = c - easeOutBounce(d - t, 0, c, d) + b;
//        }

//        public static double easeOutBounce(double t, double b, double c, double d)
//        {
//            if ((t / d) < (1 / 2.75))
//            {
//                t = t / d;

//                easeOutBounce = c * (7.5625 * t * t) + b;
//            }
//            else if (t < (2 / 2.75))
//            {
//                t = t - (1.5 / 2.75);

//                easeOutBounce = c * (7.5625 * t * t + 0.75) + b;
//            }
//            else if (t < (2.5 / 2.75))
//            {
//                t = t - (2.25 / 2.75);
//                easeOutBounce = c * (7.5625 * t * t + 0.9375) + b;
//            }
//            else
//            {
//                t = t - (2.625 / 2.75);

//                easeOutBounce = c * (7.5625 * t * t + 0.984375) + b;
//            }
//        }

//        public static double easeInOutBounce(double t, double b, double c, double d)
//        {
//            if (t < d / 2)
//                easeInOutBounce = easeInBounce(t * 2, 0, c, d) * 0.5 + b;
//            else
//                easeInOutBounce = easeOutBounce(t * 2 - d, 0, c, d) * 0.5 + c * 0.5 + b;
//        }
//    }

//}
