import React, { lazy, Suspense } from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom"
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootswatch/dist/lumen/bootstrap.min.css';
import './index.css';
import PersonContextProvider from './contexts/PersonContextProvider';
import reportWebVitals from './reportWebVitals';
import Menu from './views/menu/Menu.jsx'

const ImcApp = lazy(() => import("./apps/App"))
const OtherApp = lazy(() => import("./apps/Other"))

ReactDOM.render(
  <React.StrictMode>
    <Router>
      <Menu />
      <div className="container">
        <Routes>
          <Route path="/imc" element={<Suspense fallback={<span>loading imc...</span>}> <PersonContextProvider> <ImcApp /> </PersonContextProvider> </Suspense>} />
          <Route path="/irpf" element={<Suspense fallback={<span>loading other...</span>}> <OtherApp /> </Suspense>} />
        </Routes>
      </div>

    </Router>

  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
