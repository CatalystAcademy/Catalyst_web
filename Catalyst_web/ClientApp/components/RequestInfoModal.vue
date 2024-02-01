<template>
  <b-modal v-model="isModalOpen" title="Request Info" @hidden="closeModal">
    <!-- Form inside the modal -->
   <!-- <form @submit.prevent="submitRequest" class="custom-form">
      <label for="phoneNumber">Phone Number:</label>
      <input v-model="phoneNumber" type="text" id="phoneNumber" required class="custom-input">

      <label for="email">Email:</label>
      <input v-model="email" type="email" id="email" required class="custom-input">

      <button type="submit" class="custom-button">Submit Request</button>
    </form>-->

    <form ref="form" @submit.stop.prevent="handleSubmit">
      <b-form-group label="phone Number"
                    label-for="phoneNumber-input"
                    invalid-feedback="phone Number is required">
        <b-form-input id="name-input"
                      v-model="phoneNumber"
                      required>
        </b-form-input>
      </b-form-group>
        <b-form-group label="Email"
                    label-for="email-input"
                    invalid-feedback="Email is required"
                    >
        <b-form-input id="email-input"
                      v-model="email"                      
                      required>
        </b-form-input>
      </b-form-group>
    </form>
  </b-modal>
</template>

<script >
  export default {
    computed: {
      isModalOpen: {
        get() {
          return this.$store.state.isRequestInfoModalOpen;
        },
        set(value) {
          // You can perform additional logic when the modal state changes
          this.$store.commit('setRequestInfoModalState', value);
        },
      },
    },
    data() {
      return {
        phoneNumber: '',
        email: '',
      };
    },
    methods: {
      submitRequest() {
        // Make an HTTP request to send phone number and email
        // Close the modal after successful submission
        this.$store.dispatch('closeRequestInfoModal');
      },
      closeModal() {
        // Ensure the form is cleared when the modal is closed
        this.phoneNumber = '';
        this.email = '';
      },
    },
  };
</script>

<style module>
  
</style>
