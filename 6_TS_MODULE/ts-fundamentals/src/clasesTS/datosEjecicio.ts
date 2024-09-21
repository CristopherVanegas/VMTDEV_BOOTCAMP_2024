const persona = [
    {
        "id": 1,
        "name": "Juan Perez",
        "age": 28,
        "phone": "+34 600 123 456"
    },
    {
        "id": 2,
        "name": "María López",
        "age": 34,
        "phone": "+34 600 987 654"
    },
    {
        "id": 3,
        "name": "Carlos Ruiz",
        "age": 45,
        "phone": "+34 600 555 555"
    },
    {
        "id": 4,
        "name": "Ana García",
        "age": 30,
        "phone": "+34 600 333 333"
    },
    {
        "id": 5,
        "name": "Pedro Sánchez",
        "age": 41,
        "phone": "+34 600 111 111"
    }
]

const direccioOrigenPersona = [
    {
        "id": 1,
        "person_id": 1,
        "address": "Calle Gran Via 23, Madrid, España",
        "latitude": 40.4200,
        "longitude": -3.7050
    },
    {
        "id": 2,
        "person_id": 2,
        "address": "Avenida Diagonal 240, Barcelona, España",
        "latitude": 41.3975,
        "longitude": 2.1742
    },
    {
        "id": 3,
        "person_id": 3,
        "address": "Calle Larios 5, Málaga, España",
        "latitude": 36.7213,
        "longitude": -4.4214
    },
    {
        "id": 4,
        "person_id": 4,
        "address": "Calle Alcalá 50, Madrid, España",
        "latitude": 40.4196,
        "longitude": -3.7010
    },
    {
        "id": 5,
        "person_id": 5,
        "address": "Calle Colón 1, Valencia, España",
        "latitude": 39.4702,
        "longitude": -0.3763
    }
]

const datosDestino = [
    {
        "id": 1,
        "person_id": 1,
        "address": "Calle Serrano 25, Madrid, España",
        "latitude": 40.4300,
        "longitude": -3.6880
    },
    {
        "id": 2,
        "person_id": 1,
        "address": "Museo del Prado, Madrid, España",
        "latitude": 40.4138,
        "longitude": -3.6922
    },
    {
        "id": 3,
        "person_id": 1,
        "address": "Estadio Santiago Bernabéu, Madrid, España",
        "latitude": 40.4531,
        "longitude": -3.6884
    },
    {
        "id": 4,
        "person_id": 1,
        "address": "Parque del Retiro, Madrid, España",
        "latitude": 40.4153,
        "longitude": -3.6845
    },
    {
        "id": 5,
        "person_id": 1,
        "address": "Plaza Mayor, Madrid, España",
        "latitude": 40.4155,
        "longitude": -3.7074
    },
    {
        "id": 6,
        "person_id": 1,
        "address": "Gran Via, Madrid, España",
        "latitude": 40.4202,
        "longitude": -3.7038
    },
    {
        "id": 7,
        "person_id": 1,
        "address": "Puerta del Sol, Madrid, España",
        "latitude": 40.4169,
        "longitude": -3.7036
    },
    {
        "id": 8,
        "person_id": 2,
        "address": "Plaça Catalunya, Barcelona, España",
        "latitude": 41.3870,
        "longitude": 2.1700
    },
    {
        "id": 9,
        "person_id": 2,
        "address": "Sagrada Familia, Barcelona, España",
        "latitude": 41.4036,
        "longitude": 2.1744
    },
    {
        "id": 10,
        "person_id": 2,
        "address": "Parc Güell, Barcelona, España",
        "latitude": 41.4145,
        "longitude": 2.1527
    },
    {
        "id": 11,
        "person_id": 2,
        "address": "Barceloneta Beach, Barcelona, España",
        "latitude": 41.3784,
        "longitude": 2.1929
    },
    {
        "id": 12,
        "person_id": 2,
        "address": "Montjuïc, Barcelona, España",
        "latitude": 41.3635,
        "longitude": 2.1574
    },
    {
        "id": 13,
        "person_id": 2,
        "address": "Casa Batlló, Barcelona, España",
        "latitude": 41.3917,
        "longitude": 2.1649
    },
    {
        "id": 14,
        "person_id": 2,
        "address": "La Rambla, Barcelona, España",
        "latitude": 41.3818,
        "longitude": 2.1714
    },
    {
        "id": 15,
        "person_id": 3,
        "address": "Playa de la Malagueta, Málaga, España",
        "latitude": 36.7196,
        "longitude": -4.4102
    },
    {
        "id": 16,
        "person_id": 3,
        "address": "Museo Picasso, Málaga, España",
        "latitude": 36.7213,
        "longitude": -4.4184
    },
    {
        "id": 17,
        "person_id": 3,
        "address": "Catedral de Málaga, Málaga, España",
        "latitude": 36.7213,
        "longitude": -4.4192
    },
    {
        "id": 18,
        "person_id": 3,
        "address": "Castillo de Gibralfaro, Málaga, España",
        "latitude": 36.7256,
        "longitude": -4.4069
    },
    {
        "id": 19,
        "person_id": 3,
        "address": "Teatro Romano, Málaga, España",
        "latitude": 36.7217,
        "longitude": -4.4158
    },
    {
        "id": 20,
        "person_id": 3,
        "address": "Puerto de Málaga, Málaga, España",
        "latitude": 36.7151,
        "longitude": -4.4204
    },
    {
        "id": 21,
        "person_id": 4,
        "address": "Plaza de Cibeles, Madrid, España",
        "latitude": 40.4187,
        "longitude": -3.6921
    },
    {
        "id": 22,
        "person_id": 4,
        "address": "Puerta de Alcalá, Madrid, España",
        "latitude": 40.4206,
        "longitude": -3.6884
    },
    {
        "id": 23,
        "person_id": 4,
        "address": "Templo de Debod, Madrid, España",
        "latitude": 40.4240,
        "longitude": -3.7176
    },
    {
        "id": 24,
        "person_id": 4,
        "address": "Plaza España, Madrid, España",
        "latitude": 40.4230,
        "longitude": -3.7123
    },
    {
        "id": 25,
        "person_id": 4,
        "address": "Casa de Campo, Madrid, España",
        "latitude": 40.4159,
        "longitude": -3.7406
    },
    {
        "id": 26,
        "person_id": 4,
        "address": "Mercado San Miguel, Madrid, España",
        "latitude": 40.4152,
        "longitude": -3.7086
    },
    {
        "id": 27,
        "person_id": 5,
        "address": "Ciudad de las Artes y las Ciencias, Valencia, España",
        "latitude": 39.4535,
        "longitude": -0.3529
    },
    {
        "id": 28,
        "person_id": 5,
        "address": "Playa de la Malvarrosa, Valencia, España",
        "latitude": 39.4901,
        "longitude": -0.3293
    },
    {
        "id": 29,
        "person_id": 5,
        "address": "La Lonja de la Seda, Valencia, España",
        "latitude": 39.4746,
        "longitude": -0.3781
    },
    {
        "id": 30,
        "person_id": 5,
        "address": "Catedral de Valencia, Valencia, España",
        "latitude": 39.4750,
        "longitude": -0.3758
    },
    {
        "id": 31,
        "person_id": 5,
        "address": "Plaza del Ayuntamiento, Valencia, España",
        "latitude": 39.4699,
        "longitude": -0.3764
    },
    {
        "id": 32,
        "person_id": 5,
        "address": "Parque Natural de la Albufera, Valencia, España",
        "latitude": 39.3325,
        "longitude": -0.3183
    }
]
