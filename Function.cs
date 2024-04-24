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
            double Ki = 1 / (1 / ai + ri * Math.Pow(10, -4) + di / 2 /lambda * Math.Log(d0 / di) + (r0 * Math.Pow(10, -4) + 1 / a0) * (di / d0));
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
            double Ko = 1 / ((1 / ai + ri*Math.Pow(10,-4)) * (d0 / di) + d0 / 2 / lambda * Math.Log(d0 / di) + r0 * Math.Pow(10, -4) + 1 / a0);
            return Ko;
        }

        /// <summary>
        /// 平均传热系数
        /// </summary>
        /// <param name="ki">管内</param>
        /// <param name="k0">管外</param>
        /// <returns></returns>
        public double average_K(double ki, double k0, double d0, double di, double lambda)
        {
            double K = 1/(1 / ki + 1 / k0 + (d0 - di) /2/ lambda);
            return K;
        }
        public double average_K2(double ki, double k0)
        {
            double K = (ki+k0)/2;
            return K;
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
        /// <param name="v">管内流体的体积流量</param>
        /// <param name="n">管子数</param>
        /// <param name="m">管程</param>
        /// /// <param name="di">管内径</param>
        /// <returns></returns>
        public double fluSpeed(double q_v,double n,double m,double di)
        {
            double speed = q_v / (Math.PI * Math.Pow(di, 2) / 4 * (n / m));
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
        public double Condenser_a0(double sigma_g, double sigma_n, double r,double g, double pho_l, double mu_l, double lambda_l, double tk,double tw, double l)
        {
            double a0 = sigma_g * sigma_n * 0.725 * (1000*r * Math.Pow(pho_l, 2) * Math.Pow(lambda_l, 2) * g / mu_l / Math.Abs(tk - tw)/l);
            return a0;
        }

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
            a0 = 1.13 * Math.Pow((Math.Pow(lambda, 2) * g * Math.Pow(pho, 2) * r * 1000) / (5.5 * d0*n * mu), 0.25);
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
            double a0= 0.8* 0.9 * 0.725 * (1000*r * Math.Pow(pho_l, 2) * Math.Pow(lambda_l, 3) * g / mu_l / Math.Abs(tk - tw)/l);
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
            double a0 = c * Math.Pow(pr, 1 / 3) * lambda / delta_x * omega / 2 / L / nu;
            return a0;
        }


    }
}
