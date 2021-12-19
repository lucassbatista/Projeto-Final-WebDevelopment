import React from "react";

import ImcView from "../views/ImcView"
import ImcForm from "../views/forms/ImcForm";

const App = () => (
  <div className="container">
    <div className="row g-3 mt-3 ">
      <ImcForm />
    </div>
    <ImcView className="result" />
  </div>
)

export default App