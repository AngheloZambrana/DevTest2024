import { Field } from 'formik'
import PropTypes from 'prop-types';

export default function InputField({name, type, placeholder})
{   
    return(
        <div>
            <label htmlFor={name}></label>
            <Field name={name} type={type} placeholder={placeholder}></Field>
        </div>
    )

}

InputField.propTypes = {
    name: PropTypes.string,
    type: PropTypes.string,
    placeholder: PropTypes.string
};