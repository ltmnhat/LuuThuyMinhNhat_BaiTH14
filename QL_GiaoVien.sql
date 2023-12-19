CREATE TABLE COSO (
    macoso INT PRIMARY KEY,
    tencoso VARCHAR(255)
);

CREATE TABLE DONVI (
    madonvi INT PRIMARY KEY,
    tendonvi VARCHAR(255),
    macoso INT,
    FOREIGN KEY (macoso) REFERENCES COSO(macoso)
);

CREATE TABLE GV (
    magv INT PRIMARY KEY,
    hoten VARCHAR(255),
    sdt VARCHAR(15),
    ghichu VARCHAR(255),
    madonvi INT,
    FOREIGN KEY (madonvi) REFERENCES DONVI(madonvi)
);