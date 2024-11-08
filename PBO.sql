PGDMP  2                
    |            PBO_UTS    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    39480    PBO_UTS    DATABASE     �   CREATE DATABASE "PBO_UTS" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "PBO_UTS";
                postgres    false            �            1259    39526    akun    TABLE     �   CREATE TABLE public.akun (
    id_akun integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL,
    admin boolean NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false            �            1259    39525    akun_id_akun_seq    SEQUENCE     �   CREATE SEQUENCE public.akun_id_akun_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.akun_id_akun_seq;
       public          postgres    false    216            �           0    0    akun_id_akun_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.akun_id_akun_seq OWNED BY public.akun.id_akun;
          public          postgres    false    215            �            1259    39537    barang    TABLE     �   CREATE TABLE public.barang (
    id integer NOT NULL,
    nama character varying,
    jumlah integer NOT NULL,
    harga integer NOT NULL,
    kategori character varying NOT NULL
);
    DROP TABLE public.barang;
       public         heap    postgres    false            �            1259    39536    barang_id_seq    SEQUENCE     �   CREATE SEQUENCE public.barang_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.barang_id_seq;
       public          postgres    false    218            �           0    0    barang_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.barang_id_seq OWNED BY public.barang.id;
          public          postgres    false    217            U           2604    39529    akun id_akun    DEFAULT     l   ALTER TABLE ONLY public.akun ALTER COLUMN id_akun SET DEFAULT nextval('public.akun_id_akun_seq'::regclass);
 ;   ALTER TABLE public.akun ALTER COLUMN id_akun DROP DEFAULT;
       public          postgres    false    216    215    216            V           2604    39540 	   barang id    DEFAULT     f   ALTER TABLE ONLY public.barang ALTER COLUMN id SET DEFAULT nextval('public.barang_id_seq'::regclass);
 8   ALTER TABLE public.barang ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    217    218    218            �          0    39526    akun 
   TABLE DATA           B   COPY public.akun (id_akun, username, password, admin) FROM stdin;
    public          postgres    false    216          �          0    39537    barang 
   TABLE DATA           C   COPY public.barang (id, nama, jumlah, harga, kategori) FROM stdin;
    public          postgres    false    218   F       �           0    0    akun_id_akun_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.akun_id_akun_seq', 3, true);
          public          postgres    false    215            �           0    0    barang_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.barang_id_seq', 1, false);
          public          postgres    false    217            X           2606    39533    akun akun_id_akun_key 
   CONSTRAINT     S   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_id_akun_key UNIQUE (id_akun);
 ?   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_id_akun_key;
       public            postgres    false    216            Z           2606    39535    akun akun_username_key 
   CONSTRAINT     U   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_key UNIQUE (username);
 @   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_username_key;
       public            postgres    false    216            �      x�3�LL��̃�%\Ɯ�@������ u��      �      x������ � �     