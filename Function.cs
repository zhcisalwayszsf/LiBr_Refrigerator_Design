using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiBr_Refrigerator_Design
{
    public class Function

    {
        
        //传热系数计算总式
        /// <summary>
        /// ki传热系数计算总式
        /// </summary>
        /// <param name="a0">管外表面传热系数</param>
        /// <param name="ai">管内表面传热系数</param>
        /// <param name="r0">管外表面污垢热阻</param>
        /// <param name="ri">管内表面污垢热阻</param>
        /// <param name="d0">管外径</param>
        /// <param name="di">管内径</param>
        /// <param name="lambda">管子的传热系数</param>
        /// <returns></returns>
        public double K_in(double a0, double ai,  double r0,double ri, double d0, double di, double lambda)
        {
            double Ki = 1d / (1d / ai + ri * Math.Pow(10d, -4d) + di / 2d /lambda * Math.Log(d0 / di) + (r0 * Math.Pow(10d, -4d) + 1d / a0) * (di / d0));
            return Ki;
        }
        /// <summary>
        /// k0传热系数计算总式
        /// </summary>
        /// <param name="a0">管外表面传热系数</param>
        /// <param name="ai">管内表面传热系数</param>
        /// <param name="r0">管外表面污垢热阻</param>
        /// <param name="ri">管内表面污垢热阻</param>
        /// <param name="d0">管外径</param>
        /// <param name="di">管内径</param>
        /// <param name="lambda">管子的传热系数</param>
        /// <returns></returns>
        public double K_out(double a0, double ai,  double r0, double ri, double d0, double di,double lambda)
        {
            double Ko = 1d / ((1d / ai + ri*Math.Pow(10,-4)) * (d0 / di) + d0 / 2d / lambda * Math.Log(d0 / di) + r0 * Math.Pow(10, -4) + 1d / a0);
            return Ko;
        }

        /// <summary>
        /// 平均传热系数
        /// </summary>
        /// <param name="ki">管内</param>
        /// <param name="k0">管外</param>
        /// <returns></returns>
        public double average_K(double ki, double k0, double d0, double di, double lambda,int index)
        {
            double K;
            switch (index)
            {
                case 0:
                    K = k0;
                    return K;
                case 1:
                    K = ki;
                    return K;
                case 2:
                    K= (ki + k0) / 2;
                    return K;
                case 3:
                    K = 1 / (1 / ki + 1 / k0 + (d0 - di) / 2 / lambda);
                    return K;
                default:
                     K = k0;
                    return K;
            }
            
            
        }
    
        

        /// <summary>
        /// 所需管子数计算
        /// </summary>
        /// <param name="a">换热设备的传热面积</param>
        /// <param name="l">传热管的有效长度</param>
        /// <param name="d0">传热管外径</param>
        /// <returns></returns>
        public double tubeNumb(double a,double l,double d0)
        {
            double n=a/(Math.PI*d0*l);
            return n;
        }

        /// <summary>
        /// 管内流速计算
        /// </summary>
        /// <param name="q_v">管内流体的体积流量</param>
        /// <param name="n">管子数</param>
        /// <param name="m">管程</param>
        /// /// <param name="di">管内径</param>
        /// <returns></returns>
        public double fluSpeed(double q_v,double n,double m,double di)
        {
            double speed = q_v / (Math.PI * Math.Pow(di, 2d) / 4 * (n / m));
            return speed;
        }


        
        /// <summary>
        /// 液相水传热系数计算(温度0-370)
        /// </summary>
        /// <param name="t">液相水温度</param>
        /// <returns></returns>
        public double L_H20_lambda(double t)
        {
            double a = 56.5835753136828;
            double b = 0.182384015297712;
            double c = -0.000735270745613423;
            double d = 3.5086577174051 * Math.Pow(10, -7);
            double m = a + b * t + c * Math.Pow(t, 2) + d * Math.Pow(t, 3);
            return  0.01 * m;
        }

        /// <summary>
        /// 液相水的动力粘度mu（0-370）
        /// </summary>
        /// <param name="t">温度</param>
        /// <returns></returns>
        public double L_H20_mu(double t)
        {
            double a = 1790.32754678838;
            double b = -59.7574769915602;
            double c = 1.36455120992147;
            double d = -0.0216112648545368;
            double e = 0.000232088496738649;
            double f = -1.67508741950584E-06;
            double g = 8.07509429547523E-09;
            double h = -2.55520155249312E-11;
            double i = 5.0829453324708E-14;
            double j = -5.75557872014438E-17;
            double k = 2.82636725212962E-20;
            double m = a + b * t + c * Math.Pow(t, 2) + d * Math.Pow(t, 3) + e * Math.Pow(t, 4) + f * Math.Pow(t, 5) + g * Math.Pow(t, 6) + h * Math.Pow(t, 7) + i * Math.Pow(t, 8) + j * Math.Pow(t, 9) + k * Math.Pow(t, 10);
            return m * Math.Pow(10, -6);
        }

        /// <summary>
        /// 计算水的普朗克数
        /// </summary>
        /// <param name="t">水温</param>
        /// <returns></returns>
        public double L_H2O_Pr(double t)
        {
            double a, b, c, d, e, f, g, h, i, j, k,pr;
            a = 13.4949207490425;
            b = -0.533093709563733;
            c = 0.0151462434839127;
            d = -0.000309546190318393;
            e = 4.26511487724019E-06;
            f = -3.85477814947126E-08;
            g = 2.26701934783184E-10;
            h = -8.55466065146575E-13;
            i = 1.99192467277531E-15;
            j = -2.60080638058565E-18;
            k = 1.45502945753209E-21;
            pr = a + b * t + c * Math.Pow(t, 2) + d * Math.Pow(t, 3) + e * Math.Pow(t, 4) + f * Math.Pow(t, 5) + g * Math.Pow(t, 6) + h * Math.Pow(t, 7) + i * Math.Pow(t, 8) + j * Math.Pow(t, 9) + k * Math.Pow(t, 10);
            return pr;
        }

        public double L_H2O_nu(double t)
        {
            double a, b, c, d, e, f, g, h, i, j, k, nu;
            a = 1.7918748021782;
            b = -0.0605578550224723;
            c = 0.00143280011087931;
            d = -2.3560147014012E-05;
            e = 2.60410996607652E-07;
            f = -1.9140107684523E-09;
            g = 9.31860222951033E-12;
            h = -2.96147515718785E-14;
            i = 5.89661165922573E-17;
            j = -6.67065538321912E-20;
            k = 3.26995946461926E-23;
            nu= a + b * t + c * Math.Pow(t, 2) + d * Math.Pow(t, 3) + e * Math.Pow(t, 4) + f * Math.Pow(t, 5) + g * Math.Pow(t, 6) + h * Math.Pow(t, 7) + i * Math.Pow(t, 8) + j * Math.Pow(t, 9) + k * Math.Pow(t, 10);
            return nu*1E-6;
        }


        /// <summary>
        /// 溴化锂水溶液的定压比热容
        /// </summary>
        /// <param name="t">温度</param>
        /// <param name="x">溴化锂质量分数0-100</param>
        /// <returns></returns>
        public double LiBr_Cp(double t,double x)
        {
            double[] A = new double[3], B = new double[3], C = new double[3];
            double Cp=0;
            A[0] = 0.9928285; 
            A[1] = -1.3169179;
            A[2] = 0.6481006;
            B[0] = -3.18742E-5;
            B[1] = 2.9856E-3;
            B[2] = -4.0198E-3;
            C[0] = -3.0105E-6;
            C[1] = -1.7172E-6;
            C[2] = 8.3641E-6;
            for(int i=0; i<3;)
            {
                Cp += (A[i]+B[i]*t+C[i]*t*t)*Math.Pow(x/100d,i)*4.1868;
                i++;
            }
            return Cp;
        }

        /// <summary>
        ///溴化锂水溶液的动力粘度
        /// </summary>
        /// <param name="t">温度</param>
        /// <param name="x">溴化锂质量分数0-100</param>
        /// <returns></returns>
        public double LiBr_mu1(double t,double x)
        {
            double[] A = new double[4], B = new double[4], C = new double[4];
            double a=0, b=0, c = 0;
            double mu;
            A[0] = 1.704152;
            A[1] = 0.1084067;
            A[2] = -2.735067E-3;
            A[3] = -5.649458E-5;
            B[0] = -5.783394E-2;
            B[1] = 4.951459E-4;
            B[2] = 7.123706E-5;
            B[3] = -1.907971E-6;
            C[0] = -1.105483E-4;
            C[1] = 5.288185E-6;
            C[2] = -2.111622E-7;
            C[3] = 8.204797E-9;
            for (int i=0; i<4;)
            {
                a += A[i] *Math.Pow(x,i);
                b += B[i] * Math.Pow(x, i);
                c += C[i] * Math.Pow(x, i);
                i++;
            }
            mu=a+b+c*t*t;
            return mu*1E-3;
        }
        
        public double LiBr_mu2(double t, double x)
        {
            double mu = 0;
            double a=0, b = 0, c = 0, d = 0, e = 0;
            double[] A = new double[5], B = new double[5], C = new double[5], D = new double[5], E = new double[5];
            x = x / 100;
            A[0] = 280.29786;
            A[1] = -2467.1035;
            A[2] = 8236.95712;
            A[3] = -12295.1512;
            A[4] = 6987.19159;
            B[0] = -10.2359;
            B[1] = 88.18418;
            B[2] = -287.0873;
            B[3] = 417.76558;
            B[4] = -231.05258;
            C[0] = 0.168663;
            C[1] = -1.414004;
            C[2] = 4.464344;
            C[3] = -6.291157;
            C[4] = 3.366537;
            D[0] = -1.28817E-3;
            D[1] = 1.05791E-2;
            D[2] = -3.25918E-2;
            D[3] = 4.46873E-2;
            D[4] = -2.32197E-2;
            E[0] = 3.76484E-6;
            E[1] = -3.04581E-5;
            E[2] = 9.20812E-5;
            E[3] = -1.23458E-4;
            E[4] = 6.25342E-5;
            for (int i=0;i<5;)
            {
                a += A[i]*Math.Pow(x,i);
                b += B[i] * Math.Pow(x, i);
                c += C[i] * Math.Pow(x, i);
                d += D[i] * Math.Pow(x, i);
                e += E[i] * Math.Pow(x, i);
                i++;
            }

            mu = a+b*t+c*Math.Pow(t,2)+d* Math.Pow(t, 3)+e* Math.Pow(t, 4);
            return mu;
        }
        
            public double Libr_Lambda(double t,double x)
        {
            double a0, a1, a2, a3, a4, a5, a6;
            a0 = 0.5218988;
            a1 = 1.412948E-3;
            a2 = -6.741987E-6;
            a3 = 1.729977E-8;
            a4 = -5.514559E-3;
            a5 = 7.640728E-5;
            a6 = -6.098338E-7;
            double lambda = 1.163 * (a0 + a1 * t + a2 * Math.Pow(t, 2) + a3 * Math.Pow(t, 3) + a4 * x + a5 * Math.Pow(x, 2) + a6 * Math.Pow(x, 3));
            return lambda;
        }
















        /// <summary>
        /// 冷凝器传热面积计算
        /// </summary>
        /// <param name="q">冷凝器热负荷</param>
        /// <param name="k">冷凝器传热系数</param>
        /// <param name="tk">冷凝温度</param>
        ///  <param name="tw1">冷却水入口温度</param>
        ///  <param name="tw2">冷却水出口温度</param>
        /// <returns></returns>
        public double Condenser_Aera(double q, double k,double tk,double tw1,double tw2)
        {
            double f = 1000*q / (k * (tk - tw1) - 0.65 * (tw2 - tw1));
            return f;
        }

        /// <summary>
        /// 计算冷凝器的管内传热系数ai
        /// </summary>
        /// <param name="tw1">管内冷却水的入口温度</param>
        /// <param name="tw2">管内冷却水的出口温度</param>
        /// <param name="w">流体流速</param>
        /// <param name="di">管内径</param>
        /// <returns></returns>
        public double Condenser_ai(double tw1, double tw2, double w,double di)
        {
            double ai = 1.163 * (1230 + 19 * (tw2 - tw1) / 2) * (Math.Pow(w, 0.8) / Math.Pow(di, 0.2));
            return ai;
        }
        /// <summary>
        /// 计算冷凝器的管外传热系数a0
        /// </summary>
        /// <param name="sigma_g">不凝性气体修正系数(0.8-0.9)</param>
        /// <param name="sigma_n">管排竖直结构的修正系数(0.9)</param>
        /// <param name="r">汽化潜热</param>
        /// <param name="pho_l">液膜密度</param>
        /// <param name="mu_l">液膜的粘性系数</param>
        /// <param name="lambda_l">液膜导热率</param>
        /// <param name="l">管外径与管子在垂直方向管子排数的乘积</param>
        /// <param name="tk">冷凝温度</param>
        /// <param name="tw">管外表面平均温度</param>
        /// <returns></returns>

        /// <summary>
        /// 计算冷凝器的管外传热系数a0法2
        /// </summary>
        /// <param name="r">汽化潜热</param>
        /// <param name="g">重力加速度</param>
        /// <param name="pho">液膜密度</param>
        /// <param name="mu">液膜的粘性系数</param>
        /// <param name="lambda">液膜导热率</param>
        /// <param name="d0">管外径</param>
        /// <param name="n">管子层数</param>
        /// <returns></returns>
        public double Condenser_a02(double r,double g, double pho,double mu,double lambda,double d0,double n)
        {
            double a0;
            a0 = 1.13 * Math.Pow((Math.Pow(lambda, 2) * g * Math.Pow(pho, 2) * r * 1000) / (5.5 * d0*n * mu), 1d/4d);
            return a0;
        }


        /// <summary>
        /// 计算冷凝器的管外传热系数a0(0.8,0.9)
        /// </summary>
        /// <param name="r">汽化潜热</param>
        /// <param name="pho_l">液膜密度</param>
        /// <param name="mu_l">液膜的粘性系数</param>
        /// <param name="lambda_l">液膜导热率</param>
        /// <param name="l">管外径与管子在垂直方向管子排数的乘积</param>
        /// <param name="tk">冷凝温度</param>
        /// <param name="tw">管外表面平均温度</param>
        /// <returns></returns>
        public double Condenser_a0(double r, double g,double pho_l, double mu_l, double lambda_l,double tk,double tw, double l)
        {
            double a0= 0.9*0.725 * Math.Pow(1000 * r * Math.Pow(pho_l, 2) * Math.Pow(lambda_l, 3) * g / mu_l / Math.Abs(tk - tw) / l,1d/4d);
            return a0;
        }


        /// <summary>
        /// 吸收器的管外基准传热系数
        /// </summary>
        /// <param name="xi">吸收器喷淋溶液的质量分数(0-1)</param>
        /// <param name="gamma">喷淋密度kg/(m·h)</param>
        /// <returns></returns>
        public double Absorb_a0(double xi,double gamma)
        {
            xi = xi / 100;
            double a =1.163*(117.3*(0.89-xi)/(1.8-xi)*Math.Pow(gamma,0.615));
            return a;
        }

        /// <summary>
        /// 吸收器的管内基准传热系数方法1
        /// </summary>
        /// <param name="speed">传热管内水的平均流速</param>
        /// <param name="di">传热管外径</param>
        /// <param name="tw">冷却水进口温度</param>
        /// <param name="tw1">冷却水出口温度</param>
        /// <returns></returns>
        public double Absorb_ai(double speed, double di,double tw,double tw1)
        {
            double ai = 1.163 * (1230 + 19 * Math.Abs(tw1 - tw)) * Math.Pow(speed, 0.8) / Math.Pow(di, 0.2);
            return ai;
        }
        /// <summary>
        /// 吸收器的管内基准传热系数方法2
        /// </summary>
        /// <param name="speed">传热管内水的平均流速</param>
        /// <param name="di">传热管外径</param>
        /// <param name="delta_t">管内流体平均温度</param>
        /// <returns></returns>
        public double Absorb_ai(double speed, double di, double delta_t)
        {
            double ai = 1.163 * (1230 + 19 * delta_t) * Math.Pow(speed, 0.8) / Math.Pow(di, 0.2);
            return ai;
        }


        /// <summary>
        /// 吸收器传热面积计算
        /// </summary>
        /// <param name="q_a">吸收器总热负荷（W）</param>
        /// <param name="k">传热系数</param>
        /// <param name="tw1">冷却水出口温度</param>
        /// <param name="tw">冷却水入口温度</param>
        /// <param name="t9">进入吸收器的混合溶液温度</param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public double Absorb_Area(double q_a,double k,double tw1,double tw,double t9,double t2)
        {
            double a = q_a / k / (t9 - tw - 0.5 * (tw1 - tw) - 0.65 * (t9 - t2))*1000;
            return a;
        }

        /// <summary>
        /// 蒸发器传热面积计算
        /// </summary>
        /// <param name="q0">制冷量W</param>
        /// <param name="k">传热系数</param>
        /// <param name="t0">蒸发温度</param>
        /// <param name="tc1">冷水进口温度</param>
        /// <param name="tc2">冷水出口温度</param>
        /// <returns></returns>
        public double Evaporator_Area(double q0,double k,double t0,double tc1,double tc2)
        {
            double a = 1000 * q0 / k/(tc1 - t0 - 0.65 * (tc1 - tc2));
            return a;
        }

        /// <summary>
        /// 计算蒸发器的管内传热系数ai
        /// </summary>
        /// <param name="speed">传热管内水的平均流速</param>
        /// <param name="di">传热管外径</param>
        /// <param name="tm">管内流体平均温度</param>
        public double Evaporator_ai(double speed, double di, double tm)
        {
            double ai = 1.163 * (1230 + 19 * tm) * Math.Pow(speed, 0.8) / Math.Pow(di, 0.2);
            return ai;
        }

        /// <summary>
        /// 计算蒸发器的管外传热系数a0
        /// </summary>
        /// <param name="c">比例常数</param>
        /// <param name="pr">普朗特数</param>
        /// <param name="omega">一排管子上的冷剂喷淋量</param>
        /// <param name="L">有效管长</param>
        /// <param name="delta_x">液膜厚度</param>
        /// <param name="nu">运动粘度--平米每秒</param>
        /// <param name="lambda">水的热导率</param>
        /// <returns></returns>
        public double Evaporator_a0(double c,double pr,double omega,double L,double delta_x,double nu,double lambda)
        {
            double a0 = c * Math.Pow(pr, 1d / 3d) * lambda / delta_x * omega / 2 / L / nu;
            return a0;
        }
        
        public double Evaporator_a02(double omega,double t0,double d0)
        {
            
            double a0 = 55*(1+0.016*t0)*Math.Pow(omega/d0,1d/3d);
            return a0;
        }

        /// <summary>
        /// 高压发生器传热面积计算
        /// </summary>
        /// <param name="q">高发负荷</param>
        /// <param name="k">传热系数</param>
        /// <param name="th">，加热蒸汽（热源）相应压力下的饱和温度</param>
        /// <param name="t11">进入高发的过冷稀溶液（取相应高发压力下的饱和温度）</param>
        /// <param name="t12">高发出口浓溶液温度</param>
        /// <returns></returns>
        public double  Gh_Area(double q,double k,double th,double t11,double t12)
        {
            double a= 1000*q / k /(th - t11 - 0.65*(t12 -t11));
            return a;
        }

        
        /// <summary>
        /// 高发管外表面传热系数
        /// </summary>
        /// <param name="lambda">液相水的导热系数/param>
        /// <param name="mu">液相水的粘性系数</param>
        /// <param name="cp">液相水定压比热容J/(kg·k)</param>
        /// <param name="di">管内径</param>
        /// <param name="m">气液混合的质流密度</param>
        /// <param name="pho_l">液相水密度</param>
        /// <param name="pho_g">蒸气密度</param>
        /// <returns></returns>
        public double Gh_ai(double lambda,double mu,double cp,double di, double m,double pho_l,double pho_g)
        {
            double ai = 0.024 * lambda / di * Math.Pow(m * di / mu, 0.8) * Math.Pow(cp * mu / lambda, 0.43) * (1 + Math.Pow(pho_l / pho_g, 0.5)) / 2;
            return ai;
        }

        public  double Gh_a0()
        {
            return 15000d ;
        }

        /// <summary>
        /// 低压发生器传热面积计算
        /// </summary>
        /// <param name="q">高发负荷</param>
        /// <param name="k">传热系数</param>
        /// <param name="t3b"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <returns></returns>
        public double Gl_Area(double q, double k, double t3b,double t3,double t4)
        {
            double a = 1000 * q / k / (t3b - t3 - 0.65 * (t4 - t3));
            return a;
        }

        /// <summary>
        /// 低发管外表面传热系数
        /// </summary>
        /// <param name="lambda">液相水的导热系数/param>
        /// <param name="mu">液相水的粘性系数</param>
        /// <param name="cp">液相水定压比热容J/(kg·k)</param>
        /// <param name="di">管内径</param>
        /// <param name="m">气液混合的质流密度</param>
        /// <param name="pho_l">液相水密度</param>
        /// <param name="pho_g">蒸气密度</param>
        /// <returns></returns>
        public double Gl_ai(double lambda, double mu, double cp, double di, double m, double pho_l, double pho_g)
        {
            double ai = 0.024 * lambda / di * Math.Pow(m * di / mu, 0.8) * Math.Pow(cp * mu / lambda, 0.43) * (1 + Math.Pow(pho_l / pho_g, 0.5)) / 2;
            return ai;
        }

        public double Gl_a0()
        {
            return 15000d;
        }
        

        /// <summary>
        /// 高温热交换器传热面积
        /// </summary>
        /// <param name="q">负荷</param>
        /// <param name="k">传热系数</param>
        /// <param name="t12"></param>
        /// <param name="t10"></param>
        /// <param name="t9"></param>
        /// <param name="t2"></param>
        /// <param name="tw"></param>
        /// <returns></returns>
        public double EXH_Area(double q,double k,double t12, double t10, double t9, double t2, double tw)
        {
            double a = 1000 * q / k / (t12 - t2 - 0.35 * (t10 - tw) - 0.65*(t9 - t2));
            return a;
        }
        /// <summary>
        /// 低温热交换器传热面积
        /// </summary>
        /// <param name="q"></param>
        /// <param name="k"></param>
        /// <param name="t4"></param>
        /// <param name="t7"></param>
        /// <param name="t8"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public double EXL_Area(double q, double k, double t4, double t7, double t8, double t2)
        {
            double a = 1000 * q / k / (t4 - t2 - 0.35 * (t7 - t2) - 0.65 * (t4 - t8));
            return a;
        }
        /// <summary>
        /// 溴化锂管外传热系数（三角叉排）
        /// </summary>
        /// <param name="lambda">流体热导率</param>
        /// <param name="mu">流体粘性系数</param>
        /// <param name="Pr">普朗特数</param>
        /// <param name="phi">折流板缺口与壳体截面积之比，自定</param>
        /// <param name="omega">流体的质量流速[kg/(m^2·s)]</param>
        /// <param name="d0"></param>
        /// <returns></returns>
        public double EX_a0(double lambda,double mu,double Pr,double phi,double omega,double d0)
        {
            
            double a = 0.33 * phi * lambda / d0 * Math.Pow(omega * d0 / mu, 0.6) * Math.Pow(Pr, 0.33);
            return a;
        }
        
        /// <summary>
        /// 返回数据数组
        /// </summary>
        /// <param name="G">壳程质量流量</param>
        /// <param name="h">折流板缺口高度</param>
        /// <param name="b3">一般0.008</param>
        /// <param name="Di">筒内径</param>
        /// <param name="d0">管外径</param>
        /// <param name="ls">折流板间距</param>
        /// <param name="s">管间距（三角）</param>
        /// <param name="nt">管子数</param>
        /// <returns></returns>
        public double[] EX_Conculator(double G,double h,double b3,double Di,double d0 ,double ls, double s,double nt)
        {
            double Ac,Ab,As,Awt,Awg,theta,omega,Dl,Ds,Fc;
            Dl = Di - 2 * b3;
            Ds = Di;
            theta = 2 * Math.Acos(1 - 2 * h / Ds);
            Awg = Ds * Ds / 4 * (0.5d * theta - (1d - 2d * h / Ds) * Math.Sin(theta/2));
            Fc = (Math.PI + 2 * ((Ds - 2 * h) / Dl) * Math.Sin(Math.Acos((Ds - 2 * h) / Ds)) - 2 * Math.Acos((Ds - 2 * h) / Dl)) / Math.PI;
            Awt = Math.PI * d0 * d0 * nt * (1 - Fc)/8d;
            Ab = Awg - Awt;
            Ac = ls * (Ds - Dl + (Dl - d0) / s * (s - d0));
            As = Math.Pow(Ab*Ac,2d);
            omega = G / As;
            
            double[] results = new double[9];

            results[0] = Dl;
            results[1] = theta;
            results[2] = Fc;
            results[3] = Awg;
            results[4] = Awt;
            results[5] = Ab;
            results[6] = Ac;
            results[7] = As;
            results[8] = omega;

            return results;
        }

        public double EXW_Area(double q, double k, double ts2, double ts1,double t7, double t72)
        {
            double a = q / k / (ts2-t7-0.35*(t72-t7)-0.65*(ts1-ts2));
            return a;
        }

        

        
    }
}
